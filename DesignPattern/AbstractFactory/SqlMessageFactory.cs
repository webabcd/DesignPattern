using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// SqlMessage工厂（ConcreteFactory）
    /// </summary>
    public class SqlMessageFactory : AbstractMessageFactory
    {
        /// <summary>
        /// 创建SqlMessageModel对象
        /// </summary>
        /// <returns></returns>
        public override AbstractMessageModel CreateMessageModel()
        {
            return new SqlMessageModel();
        }

        /// <summary>
        /// 创建SqlMessage对象
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new SqlMessage();
        }
    }
}
