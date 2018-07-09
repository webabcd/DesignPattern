using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    /// <summary>
    /// �н��ߣ�ConcreteMediator��
    /// </summary>
    public class MessageMediator : AbstractMessageMediator
    {
        private Dictionary<string, AbstractMessage> _dictionary = new Dictionary<string, AbstractMessage>();

        /// <summary>
        /// ע��һ������Message�Ķ���
        /// </summary>
        /// <param name="abstractMessage">AbstractMessage</param>
        public override void Register(AbstractMessage abstractMessage)
        {
            if (!_dictionary.ContainsKey(abstractMessage.UserId))
            {
                _dictionary.Add(abstractMessage.UserId, abstractMessage);
            }

            abstractMessage.AbstractMessageMediator = this;
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="from">����UserId</param>
        /// <param name="to">���͵�UserId</param>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public override string Send(string from, string to, MessageModel mm)
        {
            AbstractMessage abstractMessage = _dictionary[to];
            if (abstractMessage != null)
            {
                return abstractMessage.Insert(from, mm);
            }
            else
            {
                return null;
            }
        }
    }
}
