using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    /// <summary>
    /// 中介者（ConcreteMediator）
    /// </summary>
    public class MessageMediator : AbstractMessageMediator
    {
        private Dictionary<string, AbstractMessage> _dictionary = new Dictionary<string, AbstractMessage>();

        /// <summary>
        /// 注册一个操作Message的对象
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
        /// 发送Message
        /// </summary>
        /// <param name="from">来自UserId</param>
        /// <param name="to">发送到UserId</param>
        /// <param name="mm">Message实体对象</param>
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
