using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    /// <summary>
    /// �������ӿڣ�IIterator��
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// ��һ������
        /// </summary>
        /// <returns></returns>
        MessageModel First();

        /// <summary>
        /// ��һ������
        /// </summary>
        /// <returns></returns>
        MessageModel Next();

        /// <summary>
        /// ��ǰ����
        /// </summary>
        MessageModel CurrentMessageModel { get; }

        /// <summary>
        /// �Ƿ�������
        /// </summary>
        bool IsDone { get; }
    }
}
