using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// XmlMessage������ConcreteFactory��
    /// </summary>
    public class XmlMessageFactory : AbstractMessageFactory
    {
        /// <summary>
        /// ����XmlMessageModel����
        /// </summary>
        /// <returns></returns>
        public override AbstractMessageModel CreateMessageModel()
        {
            return new XmlMessageModel();
        }

        /// <summary>
        /// ����XmlMessage����
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new XmlMessage();
        }
    }
}
