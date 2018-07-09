using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    /// <summary>
    /// Sql方式操作Message（Originator）
    /// </summary>
    public class SqlMessage
    {
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
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            // 秒数可以被5整除时，则执行插入操作
            if (mm.PublishTime.Second % 5 == 0)
            {
                // 代码略
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 保存Memento
        /// </summary>
        /// <returns></returns>
        public MessageModel SaveMemento()
        {
            return new MessageModel(_message, _publishTime);
        }

        /// <summary>
        /// 恢复Memento
        /// </summary>
        /// <param name="mm"></param>
        public void RestoreMemento(MessageModel mm)
        {
            this._message = mm.Message;
            this._publishTime = mm.PublishTime;
        }
    }
}
