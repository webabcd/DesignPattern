using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// ����Ԫ�أ�Element��
    /// </summary>
    public abstract class AbstractElement
    {
        /// <summary>
        /// ִ�г�������ߵ�Visit()�������Ӷ�ִ�г���Ԫ�صķ�����
        /// </summary>
        /// <param name="abstractVisitor">���������</param>
        /// <returns></returns>
        public abstract string Accept(AbstractVisitor abstractVisitor);
    }
}
