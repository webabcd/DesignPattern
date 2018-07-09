using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// SqlMessage工厂（ConcreteCreator）
    /// </summary>
    public class SqlMessageFactory : AbstractMessageFactory
    {
        /// <summary>
        /// 实现工厂方法，返回SqlMessage对象
        /// </summary>
        /// <returns></returns>
        public override AbstractMessage CreateMessage()
        {
            return new SqlMessage();
        }
    }
}
