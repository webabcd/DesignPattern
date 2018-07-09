using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    /// <summary>
    /// ����Message��Abstraction��
    /// </summary>
    public class Message
    {
        private AbstractMessage _abstractMessage;
        /// <summary>
        /// ����Message��Implementor��
        /// </summary>
        public AbstractMessage AbstractMessage
        {
            get { return _abstractMessage; }
            set { _abstractMessage = value; }
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public virtual List<MessageModel> Get()
        {
            return _abstractMessage.Get();
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public virtual bool Insert(MessageModel mm)
        {
            return _abstractMessage.Insert(mm);
        }
    }
}
