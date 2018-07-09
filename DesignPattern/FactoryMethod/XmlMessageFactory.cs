using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// XmlMessage������ConcreteCreator��
    /// </summary>
    public class XmlMessageFactory : AbstractMessageFactory
    {
        /// <summary>
        /// ʵ�ֹ�������������XmlMessage����
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new XmlMessage();
        }
    }
}
