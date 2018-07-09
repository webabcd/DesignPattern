using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// 抽象Message主题（Subject）
    /// </summary>
    public abstract class AbstractMessageSubject
    {
        private MessageModel _messageModel;
        private List<IMessage> list = new List<IMessage>();

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public AbstractMessageSubject(MessageModel mm)
        {
            this._messageModel = mm;
        }

        /// <summary>
        /// 添加一个实现IMessage接口的对象
        /// </summary>
        /// <param name="m">实现IMessage接口的对象</param>
        public void Attach(IMessage m)
        {
            list.Add(m);
        }

        /// <summary>
        /// 移除一个实现IMessage接口的对象
        /// </summary>
        /// <param name="m">实现IMessage接口的对象</param>
        public void Detach(IMessage m)
        {
            list.Remove(m);
        }

        /// <summary>
        /// 通知所有观察者
        /// </summary>
        /// <returns></returns>
        public string Notify()
        {
            string s = "";
            foreach (IMessage i in list)
            {
                s += i.Insert(_messageModel);
                s += Environment.NewLine;
            }

            return s;
        }

        /// <summary>
        /// Message发布时间
        /// </summary>
        public DateTime PublishTime
        {
            get { return _messageModel.PublishTime; }
            set
            {
                _messageModel.PublishTime = value;
                Notify();
            }
        }
    }
}
