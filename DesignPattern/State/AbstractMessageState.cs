using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// 状态模式抽象类
    /// </summary>
    public abstract class AbstractMessageState
    {
        /// <summary>
        /// Context类型
        /// </summary>
        protected Message _message;

        /// <summary>
        /// Context类型属性
        /// </summary>
        public Message Message
        {
            get { return _message; }
            set { _message = value; }
        }

        /// <summary>
        /// 改变状态
        /// </summary>
        public abstract void StateChangeCheck();

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public abstract bool Insert(MessageModel mm);
    }
}
