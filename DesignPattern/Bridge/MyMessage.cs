using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    /// <summary>
    /// ²Ù×÷Message£¨RefinedAbstraction£©
    /// </summary>
    public class MyMessage : Message
    {
        /// <summary>
        /// »ñÈ¡Message
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = base.Get();

            foreach (MessageModel mm in l)
            {
                mm.Message += "£¨RefinedAbstraction£©";
            }

            return l;
        }
    }
}
