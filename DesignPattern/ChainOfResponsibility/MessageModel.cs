using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// Message实体类
    /// </summary>
    public class MessageModel
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg">Message内容</param>
        /// <param name="pt">Message发布时间</param>
        public MessageModel(string msg, DateTime pt)
        {
            this._message = msg;
            this._publishTime = pt;
        }

        private string _message;
        /// <summary>
        /// Message内容
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        private DateTime _publishTime;
        /// <summary>
        /// Message发布时间
        /// </summary>
        public DateTime PublishTime
        {
            get { return _publishTime; }
            set { _publishTime = value; }
        }
    }
}
