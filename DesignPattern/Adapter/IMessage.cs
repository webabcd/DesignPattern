using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// 目标（Target）角色
    /// 操作Message的接口
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        List<MessageModel> Select();

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        bool Add(MessageModel mm);
    }
}
