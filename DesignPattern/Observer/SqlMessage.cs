using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// Sql方式操作Message（ConcreteObserver）
    /// </summary>
    public class SqlMessage : IMessage
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public string Insert(MessageModel mm)
        {
            return "sql方式：" + mm.Message + " " + mm.PublishTime.ToString();
        } 
    }
}
