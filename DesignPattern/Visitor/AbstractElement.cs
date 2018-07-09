using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// 抽象元素（Element）
    /// </summary>
    public abstract class AbstractElement
    {
        /// <summary>
        /// 执行抽象访问者的Visit()方法（从而执行抽象元素的方法）
        /// </summary>
        /// <param name="abstractVisitor">抽象访问者</param>
        /// <returns></returns>
        public abstract string Accept(AbstractVisitor abstractVisitor);
    }
}
