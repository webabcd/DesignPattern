using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// 扩展出输入验证的功能（ConcreteDecorator）
    /// </summary>
    public class CheckInputWrapper : AbstractMessageWrapper
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="abstractMessage">AbstractMessage</param>
        public CheckInputWrapper(AbstractMessage abstractMessage)
            : base(abstractMessage)
        {
            
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = base.Get();

            foreach (MessageModel mm in l)
            {
                mm.Message += "（经过输入验证）";
            }

            return l;
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public override bool Insert(MessageModel mm)
        {
            // 在这里扩展功能

            return base.Insert(mm);
        }
    }
}
