using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// ��������ߣ�Visitor��
    /// </summary>
    public abstract class AbstractVisitor
    {
        /// <summary>
        /// ִ�г���Ԫ�صķ���
        /// </summary>
        /// <param name="abstractElement">����Ԫ��</param>
        /// <returns></returns>
        public abstract string Visit(AbstractElement abstractElement);
    }
}
