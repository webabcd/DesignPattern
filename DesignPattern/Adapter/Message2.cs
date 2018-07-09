using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// 适配器（Adapter）角色
    /// 对象适配器
    /// 把源适配到这个类
    /// </summary>
    public class Message2 : IMessage
    {
        private SqlMessage _sqlMessage;

        /// <summary>
        /// 构造函数
        /// </summary>
        public Message2()
        {
            _sqlMessage = new SqlMessage();
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Select()
        {
            return _sqlMessage.Get();
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Add(MessageModel mm)
        {
            return _sqlMessage.Insert(mm);
        }
    }
}
