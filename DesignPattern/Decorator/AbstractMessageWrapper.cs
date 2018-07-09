using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// 装饰AbstractMessage（Decorator）
    /// </summary>
    public abstract class AbstractMessageWrapper : AbstractMessage
    {
        private AbstractMessage _abstractMessage;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="abstractMessage">AbstractMessage</param>
        public AbstractMessageWrapper(AbstractMessage abstractMessage)
        {
            this._abstractMessage = abstractMessage;
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            return _abstractMessage.Get();
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public override bool Insert(MessageModel mm)
        {
            return _abstractMessage.Insert(mm);
        }
    }
}
