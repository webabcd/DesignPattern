using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// Get�����ߣ�ConcreteVisitor��
    /// </summary>
    public class GetVisitor : AbstractVisitor
    {
        /// <summary>
        /// ִ��Message��Get()����
        /// </summary>
        /// <param name="abstractElement">����Ԫ��</param>
        /// <returns></returns>
        public override string Visit(AbstractElement abstractElement)
        {
            Message m = abstractElement as Message;

            return m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString();
        }
    }
}
