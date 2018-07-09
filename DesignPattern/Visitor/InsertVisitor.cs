using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// Insert访问者（ConcreteVisitor）
    /// </summary>
    public class InsertVisitor : AbstractVisitor
    {
        /// <summary>
        /// 执行Message的Insert()方法
        /// </summary>
        /// <param name="abstractElement">抽象元素</param>
        /// <returns></returns>
        public override string Visit(AbstractElement abstractElement)
        {
            Message m = abstractElement as Message;

            return m.Insert().ToString();
        }
    }
}
