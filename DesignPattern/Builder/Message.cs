using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 指导者（Director）
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 调用具体建造者角色以创建产品对象
        /// </summary>
        /// <param name="messageBuilder">AbstractMessageBuilder</param>
        /// <param name="mm">Message实体对象</param>
        public void Construct(AbstractMessageBuilder messageBuilder, MessageModel mm)
        {
            messageBuilder.BuilderInsert(mm);
            messageBuilder.BuilderGet();
        }
    }
}
