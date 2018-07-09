using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// Insert�����ߣ�ConcreteVisitor��
    /// </summary>
    public class InsertVisitor : AbstractVisitor
    {
        /// <summary>
        /// ִ��Message��Insert()����
        /// </summary>
        /// <param name="abstractElement">����Ԫ��</param>
        /// <returns></returns>
        public override string Visit(AbstractElement abstractElement)
        {
            Message m = abstractElement as Message;

            return m.Insert().ToString();
        }
    }
}
