using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// XmlMessage工厂（ConcreteFactory）
    /// </summary>
    public class XmlMessageFactory : AbstractMessageFactory
    {
        /// <summary>
        /// 创建XmlMessageModel对象
        /// </summary>
        /// <returns></returns>
        public override AbstractMessageModel CreateMessageModel()
        {
            return new XmlMessageModel();
        }

        /// <summary>
        /// 创建XmlMessage对象
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new XmlMessage();
        }
    }
}
