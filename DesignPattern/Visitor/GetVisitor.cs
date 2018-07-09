using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// Get访问者（ConcreteVisitor）
    /// </summary>
    public class GetVisitor : AbstractVisitor
    {
        /// <summary>
        /// 执行Message的Get()方法
        /// </summary>
        /// <param name="abstractElement">抽象元素</param>
        /// <returns></returns>
        public override string Visit(AbstractElement abstractElement)
        {
            Message m = abstractElement as Message;

            return m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString();
        }
    }
}
