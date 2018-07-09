using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// SqlMessage������ConcreteCreator��
    /// </summary>
    public class SqlMessageFactory : AbstractMessageFactory
    {
        /// <summary>
        /// ʵ�ֹ�������������SqlMessage����
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new SqlMessage();
        }
    }
}
