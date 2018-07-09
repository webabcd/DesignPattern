using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// Xml方式操作Message（ConcreteObserver）
    /// </summary>
    public class XmlMessage : IMessage
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public string Insert(MessageModel mm)
        {
            return "xml方式：" + mm.Message + " " + mm.PublishTime.ToString();
        } 
    }
}
