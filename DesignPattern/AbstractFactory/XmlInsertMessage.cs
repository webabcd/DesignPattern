using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class XmlInsertMessage : AbstractInsertMessage
    {
        public override string Insert(AbstractMessageModel amm)
        {
            return "ddddddd";
        }
    }
}
