using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    /// <summary>
    /// 代理类
    /// </summary>
    public class MessageProxy : IMessage
    {
        SqlMessage _sqlMessage;

        /// <summary>
        /// 构造函数
        /// </summary>
        public MessageProxy()
        {
            _sqlMessage = new SqlMessage();
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            return _sqlMessage.Get();
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            return _sqlMessage.Insert(mm);
        }
    }
}
