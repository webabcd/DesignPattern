using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// Message主题（ConcreteSubject）
    /// </summary>
    public class MessageSubject : AbstractMessageSubject
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public MessageSubject(MessageModel mm)
            : base(mm)
        {
 
        }
    }
}
