using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 抽象Message工厂（AbstractFactory）
    /// </summary>
    public abstract class AbstractMessageFactory
    {
        /// <summary>
        /// 创建MessageModel对象
        /// </summary>
        /// <returns></returns>
        public abstract AbstractMessageModel CreateMessageModel();

        /// <summary>
        /// 创建Message对象
        /// </summary>
        /// <returns></returns>
        public abstract AbstractMessage CreateMessage();
    }
}