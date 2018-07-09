using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    /// <summary>
    /// Xml方式操作Message（ConcreteColleague）
    /// </summary>
    public class XmlMessage : AbstractMessage
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
        /// 接受Message（由中介者调用）
        /// </summary>
        /// <param name="from">来自UserId</param>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public override string Insert(string from, MessageModel mm)
        {
            return "Xml方式插入Message（" + from + "发送给" + base.UserId + "）"
                + " - 内容：" + mm.Message
                + " - 时间：" + mm.PublishTime.ToString();
        }
    }
}
