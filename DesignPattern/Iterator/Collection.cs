using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    /// <summary>
    /// 集合（ConcreteAggregate）
    /// </summary>
    public class Collection : ICollection
    {
        private List<MessageModel> list = new List<MessageModel>();

        /// <summary>
        /// 创建迭代器对象
        /// </summary>
        /// <returns></returns>
        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }

        /// <summary>
        /// 集合内的对象总数
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="index">index</param>
        /// <returns></returns>
        public MessageModel this[int index]
        {
            get { return list[index]; }
            set { list.Add(value); }
        }

    }
}
