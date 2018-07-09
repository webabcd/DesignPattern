using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// Xml方式操作Message（ConcreteElement）
    /// </summary>
    public class XmlMessage : Message
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public XmlMessage(MessageModel mm)
            : base(mm)
        {
 
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("XML方式获取Message", DateTime.Now));

            return l;
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <returns></returns>
        public override bool Insert()
        {
            // 代码略
            return true;
        }
    }
}
