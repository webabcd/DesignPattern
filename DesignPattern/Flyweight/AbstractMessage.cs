using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    /// <summary>
    /// 操作Message抽象类（Flyweight）
    /// </summary>
    public abstract class AbstractMessage
    {
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public abstract bool Insert(MessageModel mm);
    }
}
