using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    /// <summary>
    /// �����ߣ�Receiver����ɫ
    /// Sql��ʽ����Message
    /// </summary>
    public class SqlMessage
    {
        /// <summary>
        /// ����
        /// </summary>
        /// <param name="action">�����ķ���</param>
        /// <param name="mm">Messageʵ�����</param>
        public void Operation(Action action, MessageModel mm)
        {
            switch (action)
            {
                case Action.Insert : 
                    Insert(mm); 
                    break;
                case Action.Delete :
                    Delete(mm);
                    break;
            }
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        private void Insert(MessageModel mm)
        {
            // ������
        }

        /// <summary>
        /// ɾ��Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        private void Delete(MessageModel mm)
        {
            // ������
        }
    }
}
