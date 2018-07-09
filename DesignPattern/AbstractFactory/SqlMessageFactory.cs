using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// SqlMessage������ConcreteFactory��
    /// </summary>
    public class SqlMessageFactory : AbstractMessageFactory
    {
        /// <summary>
        /// ����SqlMessageModel����
        /// </summary>
        /// <returns></returns>
        public override AbstractMessageModel CreateMessageModel()
        {
            return new SqlMessageModel();
        }

        /// <summary>
        /// ����SqlMessage����
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new SqlMessage();
        }
    }
}
