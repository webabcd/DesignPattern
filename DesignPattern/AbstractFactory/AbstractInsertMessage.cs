using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public abstract class AbstractInsertMessage
    {
        public abstract string Insert(AbstractMessageModel amm);
    }
}
