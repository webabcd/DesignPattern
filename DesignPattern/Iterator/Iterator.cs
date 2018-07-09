using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    /// <summary>
    /// ��������Iterator��
    /// </summary>
    public class Iterator : IIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="collection"></param>
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        /// <summary>
        /// ��һ������
        /// </summary>
        /// <returns></returns>
        public MessageModel First()
        {
            _current = 0;
            return _collection[_current];
        }

        /// <summary>
        /// ��һ������
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
        /// ��ǰ����
        /// </summary>
        public MessageModel CurrentMessageModel
        {
            get { return _collection[_current]; }
        }

        /// <summary>
        /// �Ƿ�������
        /// </summary>
        public bool IsDone
        {
            get { return _current >= _collection.Count ? true : false; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }
    }
}
