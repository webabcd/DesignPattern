using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// 操作Message抽象类（Element）
    /// </summary>
    public abstract class Message : AbstractElement
    {
        private MessageModel _messageModel;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public Message(MessageModel mm)
        {
            this._messageModel = mm;
        }

        /// <summary>
        /// Message实体对象
        /// </summary>
        public MessageModel MessageModel
        {
            get { return _messageModel; }
            set { _messageModel = value; }
        }

        /// <summary>
        /// 执行抽象访问者的Visit()方法（从而执行抽象元素的方法）
        /// </summary>
        /// <param name="abstractVisitor">抽象访问者</param>
        /// <returns></returns>
        public override string Accept(AbstractVisitor abstractVisitor)
        {
            return abstractVisitor.Visit(this);
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <returns></returns>
        public abstract bool Insert();
    }
}
