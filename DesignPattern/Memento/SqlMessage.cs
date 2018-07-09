using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    /// <summary>
    /// Sql��ʽ����Message��Originator��
    /// </summary>
    public class SqlMessage
    {
        private string _message;
        /// <summary>
        /// Message����
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private DateTime _publishTime;
        /// <summary>
        /// Message����ʱ��
        /// </summary>
        public DateTime PublishTime
        {
            get { return _publishTime; }
            set { _publishTime = value; }
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            // �������Ա�5����ʱ����ִ�в������
            if (mm.PublishTime.Second % 5 == 0)
            {
                // ������
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ����Memento
        /// </summary>
        /// <returns></returns>
        public MessageModel SaveMemento()
        {
            return new MessageModel(_message, _publishTime);
        }

        /// <summary>
        /// �ָ�Memento
        /// </summary>
        /// <param name="mm"></param>
        public void RestoreMemento(MessageModel mm)
        {
            this._message = mm.Message;
            this._publishTime = mm.PublishTime;
        }
    }
}
