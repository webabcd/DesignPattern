using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    /// <summary>
    /// Xml方式操作Message
    /// </summary>
    public class XmlMessage : AbstractMessageTemplate
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId">UserId</param>
        public XmlMessage(string userId)
            : base(userId)
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
    }
}
