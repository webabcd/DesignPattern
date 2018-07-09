using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// Context类
    /// </summary>
    public class Message
    {
        private AbstractMessage _insertMessage;
        private AbstractMessageModel _messageModel;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="factory">AbstractMessageFactory</param>
        public Message(AbstractMessageFactory factory)
        {
            DateTime pt = DateTime.Now;

            _insertMessage = factory.CreateMessage();
            _messageModel = factory.CreateMessageModel();

        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <param name="msg">Message内容</param>
        /// <param name="pt">Message发布时间</param>
        /// <returns></returns>
        public string Insert(string userId, string msg, DateTime pt)
        {
            _messageModel.UserId = userId;
            _messageModel.Message = msg;
            _messageModel.PublishTime = pt;

            return _insertMessage.Insert(_messageModel);
        }
    }
}
