using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    /// <summary>
    /// 迭代器接口（IIterator）
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// 第一个对象
        /// </summary>
        /// <returns></returns>
        MessageModel First();

        /// <summary>
        /// 下一个对象
        /// </summary>
        /// <returns></returns>
        MessageModel Next();

        /// <summary>
        /// 当前对象
        /// </summary>
        MessageModel CurrentMessageModel { get; }

        /// <summary>
        /// 是否迭代完毕
        /// </summary>
        bool IsDone { get; }
    }
}
