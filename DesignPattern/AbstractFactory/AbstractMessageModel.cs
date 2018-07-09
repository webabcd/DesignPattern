using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 抽象Message实体类（AbstractProduct）
    /// </summary>
    public abstract class AbstractMessageModel
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public AbstractMessageModel()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg">Message内容</param>
        /// <param name="pt">Message发布时间</param>
        public AbstractMessageModel(string msg, DateTime pt)
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

        /// <summary>
        /// UserId
        /// </summary>
        public abstract string UserId
        {
            get;
            set;
        }
    }
}
