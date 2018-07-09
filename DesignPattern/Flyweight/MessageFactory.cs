using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    /// <summary>
    /// Message������FlyweightFactory��
    /// </summary>
    public class MessageFactory
    {
        private Dictionary<string, AbstractMessage> _messageObjects = new Dictionary<string, AbstractMessage>();

        /// <summary>
        /// ��ȡMessage����
        /// </summary>
        /// <param name="key">key</param>
        /// <returns></returns>
        public AbstractMessage GetMessageObject(string key)
        {
            AbstractMessage messageObject = null;

            if (_messageObjects.ContainsKey(key))
            {
                messageObject = _messageObjects[key];
            }
            else
            {
                switch (key)
                {
                    case "xml": messageObject = new SqlMessage(); break;
                    case "sql": messageObject = new XmlMessage(); break;
                }

                _messageObjects.Add(key, messageObject);
            }

            return messageObject;
        }
    }
}
