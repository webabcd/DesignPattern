using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// 适配器（Adapter）角色
    /// 类适配器
    /// 把源适配到这个类
    /// </summary>
    public class Message : SqlMessage, IMessage
    {
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Select()
        {
            return base.Get();
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Add(MessageModel mm)
        {
            return base.Insert(mm);
        }
    }
}
