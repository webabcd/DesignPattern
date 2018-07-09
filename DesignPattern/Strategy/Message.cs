using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    /// <summary>
    /// Context��
    /// </summary>
    public class Message
    {
        /// <summary>
        /// ����һ��IMessageStrategy����
        /// </summary>
        private IMessageStrategy _strategy;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="strategy">�����㷨</param>
        public Message(IMessageStrategy strategy)
        {
            this._strategy = strategy;
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            return _strategy.Get();
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            return _strategy.Insert(mm);
        }
    }
}
