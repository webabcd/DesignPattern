using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// ״̬ģʽ������
    /// </summary>
    public abstract class AbstractMessageState
    {
        /// <summary>
        /// Context����
        /// </summary>
        protected Message _message;

        /// <summary>
        /// Context��������
        /// </summary>
        public Message Message
        {
            get { return _message; }
            set { _message = value; }
        }

        /// <summary>
        /// �ı�״̬
        /// </summary>
        public abstract void StateChangeCheck();

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public abstract bool Insert(MessageModel mm);
    }
}
