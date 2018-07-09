using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    /// <summary>
    /// 对Message操作的接口
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        List<MessageModel> Get();

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        bool Insert(MessageModel mm);
    }
}
