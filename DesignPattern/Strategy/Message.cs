using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    /// <summary>
    /// Context类
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 声明一个IMessageStrategy类型
        /// </summary>
        private IMessageStrategy _strategy;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="strategy">具体算法</param>
        public Message(IMessageStrategy strategy)
        {
            this._strategy = strategy;
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            return _strategy.Get();
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            return _strategy.Insert(mm);
        }
    }
}
