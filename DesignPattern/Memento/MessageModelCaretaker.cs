using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    /// <summary>
    /// Memento管理者（Caretaker）
    /// </summary>
    public class MessageModelCaretaker
    {
        private MessageModel _messageModel;

        /// <summary>
        /// Message实体对象（Memento）
        /// </summary>
        public MessageModel MessageModel
        {
            get { return _messageModel; }
            set { _messageModel = value; }
        }
    }
}
