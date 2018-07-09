using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    /// <summary>
    /// 操作Message（Abstraction）
    /// </summary>
    public class Message
    {
        private AbstractMessage _abstractMessage;
        /// <summary>
        /// 操作Message（Implementor）
        /// </summary>
        public AbstractMessage AbstractMessage
        {
            get { return _abstractMessage; }
            set { _abstractMessage = value; }
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public virtual List<MessageModel> Get()
        {
            return _abstractMessage.Get();
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public virtual bool Insert(MessageModel mm)
        {
            return _abstractMessage.Insert(mm);
        }
    }
}
