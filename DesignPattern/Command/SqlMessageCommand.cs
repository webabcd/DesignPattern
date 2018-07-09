using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    /// <summary>
    /// �������ConcreteCommand����ɫ
    /// </summary>
    public class SqlMessageCommand : ICommand
    {
        /// <summary>
        /// �����ķ���
        /// </summary>
        private Action _action;

        /// <summary>
        /// Messageʵ�����
        /// </summary>
        private MessageModel _mm;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="action">�����ķ���</param>
        /// <param name="mm">Messageʵ�����</param>
        public SqlMessageCommand(Action action, MessageModel mm)
        {
            this._action = action;
            this._mm = mm;
        }

        /// <summary>
        /// ִ��
        /// </summary>
        /// <returns>�����ķ�������������Ϣ</returns>
        public string Execute()
        {
            new SqlMessage().Operation(_action, _mm);

            return _action.ToString() + "��" + _mm.Message;
        }

        /// <summary>
        /// ȡ��ִ�У�����һ���������Ծ���ȡ��ִ�е��㷨��
        /// </summary>
        /// <returns>�����ķ�������������Ϣ</returns>
        public string UnExecute()
        {
            _action = GetUndoAction(_action);
            new SqlMessage().Operation(_action, _mm);

            return _action.ToString() + "��" + _mm.Message;
        }

        /// <summary>
        /// ���ȡ��ִ�е��㷨
        /// </summary>
        /// <param name="action">�����ķ���</param>
        /// <returns></returns>
        private Action GetUndoAction(Action action)
        {
            Action undo;

            switch (action)
            {
                case Action.Insert : 
                    undo = Action.Delete; 
                    break;
                case Action.Delete :
                    undo = Action.Insert;
                    break;
                // ���ûɶ��
                default :
                    undo = Action.Insert;
                    break;
            }

            return undo;
        }
    }
}
