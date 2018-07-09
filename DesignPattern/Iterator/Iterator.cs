using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    /// <summary>
    /// 迭代器（Iterator）
    /// </summary>
    public class Iterator : IIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="collection"></param>
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        /// <summary>
        /// 第一个对象
        /// </summary>
        /// <returns></returns>
        public MessageModel First()
        {
            _current = 0;
            return _collection[_current];
        }

        /// <summary>
        /// 下一个对象
        /// </summary>
        /// <returns></returns>
        public MessageModel Next()
        {
            _current += _step;

            if (!IsDone)
            {
                return _collection[_current];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 当前对象
        /// </summary>
        public MessageModel CurrentMessageModel
        {
            get { return _collection[_current]; }
        }

        /// <summary>
        /// 是否迭代完毕
        /// </summary>
        public bool IsDone
        {
            get { return _current >= _collection.Count ? true : false; }
        }

        /// <summary>
        /// 步长
        /// </summary>
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }
    }
}
