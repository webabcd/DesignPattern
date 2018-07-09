using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// 抽象访问者（Visitor）
    /// </summary>
    public abstract class AbstractVisitor
    {
        /// <summary>
        /// 执行抽象元素的方法
        /// </summary>
        /// <param name="abstractElement">抽象元素</param>
        /// <returns></returns>
        public abstract string Visit(AbstractElement abstractElement);
    }
}
