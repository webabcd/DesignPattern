using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    /// <summary>
    /// ���ϣ�ConcreteAggregate��
    /// </summary>
    public class Collection : ICollection
    {
        private List<MessageModel> list = new List<MessageModel>();

        /// <summary>
        /// ��������������
        /// </summary>
        /// <returns></returns>
        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }

        /// <summary>
        /// �����ڵĶ�������
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// ������
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
