using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// Sql方式操作Message
    /// </summary>
    public class SqlMessage : AbstractMessageState
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">Context类型参数</param>
        public SqlMessage(Message message)
        {
            this._message = message;
        }

        /// <summary>
        /// 改变状态
        /// </summary>
        public override void StateChangeCheck()
        {

        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("SQL方式获取Message", DateTime.Now));

            return l;
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public override bool Insert(MessageModel mm)
        {
            // 代码略
            return true;
        }
    }
}
