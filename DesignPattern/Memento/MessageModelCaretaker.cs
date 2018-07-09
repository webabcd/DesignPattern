using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    /// <summary>
    /// Memento�����ߣ�Caretaker��
    /// </summary>
    public class MessageModelCaretaker
    {
        private MessageModel _messageModel;

        /// <summary>
        /// Messageʵ�����Memento��
        /// </summary>
        public MessageModel MessageModel
        {
            get { return _messageModel; }
            set { _messageModel = value; }
        }
    }
}
