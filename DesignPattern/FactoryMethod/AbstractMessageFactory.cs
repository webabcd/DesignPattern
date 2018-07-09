using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// 抽象Message工厂（Creator）
    /// </summary>
    public abstract class AbstractMessageFactory
    {
        // An Operation

        /// <summary>
        /// 工厂方法
        /// </summary>
        /// <returns>AbstractMessage</returns>
        public abstract AbstractMessage CreateMessage();
    }
}
