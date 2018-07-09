using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Iterator
{
    /// <summary>
    /// 集合接口（Aggregate）
    /// </summary>
    public interface ICollection
    {
        /// <summary>
        /// 创建迭代器对象
        /// </summary>
        /// <returns></returns>
        IIterator CreateIterator();
    }
}
