using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    /// <summary>
    /// �����ߣ�Invoker����ɫ
    /// </summary>
    public class Message
    {
        /// <summary>
        /// ����ϣ�����ÿ�β�����
        /// </summary>
        private List<ICommand> _listCommand = new List<ICommand>();

        /// <summary>
        /// ������е�ǰҪִ�е����������
        /// </summary>
        private int current = 0;

        /// <summary>
        /// ִ��Sql
        /// </summary>
        /// <param name="action">�����ķ���</param>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns>�����ķ�������������Ϣ</returns>
        public string Do(Action action, MessageModel mm)
        {
            string rtn = "";

            ICommand cmd = new SqlMessageCommand(action, mm);
            rtn = cmd.Execute();

            _listCommand.Add(cmd);
            current++;

            return rtn;
        }

        /// <summary>
        /// ����
        /// </summary>
        /// <param name="levels">ִ�г��������Ĵ���</param>
        /// <returns>�����ķ�������������Ϣ���ÿո�ֿ�������¼��</returns>
        public string Undo(int levels)
        {
            string rtn = "";

            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    ICommand cmd = _listCommand[--current];
                    rtn += cmd.UnExecute() + " ";
                }
            }

            return rtn;
        }

        /// <summary>
        /// �ظ�
        /// </summary>
        /// <param name="levels">ִ���ظ������Ĵ���</param>
        /// <returns>�����ķ�������������Ϣ���ÿո�ֿ�������¼��</returns>
        public string Redo(int levels)
        {
            string rtn = "";

            for (int i = 0; i < levels; i++)
            {
                if (current < _listCommand.Count - 1)
                {
                    ICommand cmd = _listCommand[current++];
                    rtn += cmd.UnExecute() + " ";
                }
            }

            return rtn;
        }
    }
}
