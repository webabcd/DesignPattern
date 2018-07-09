using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// 操作Message的接口（Observer）
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        string Insert(MessageModel mm);
    }
}
