using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    /// <summary>
    /// 操作Message抽象类（Colleague）
    /// </summary>
    public abstract class AbstractMessage
    {
        private AbstractMessageMediator _abstractMessageMediator;
        private string _userId;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId">UserId</param>
        public AbstractMessage(string userId)
        {
            this._userId = userId;
        }

        /// <summary>
        /// UserId
        /// </summary>
        public string UserId
        {
            get { return _userId; }
        }

        /// <summary>
        /// 中介者
        /// </summary>
        public AbstractMessageMediator AbstractMessageMediator
        {
            get { return _abstractMessageMediator; }
            set { _abstractMessageMediator = value; }
        }

        /// <summary>
        /// 发送Message（由客户端调用）
        /// </summary>
        /// <param name="to">发送到UserId</param>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public string Send(string to, MessageModel mm)
        {
            return _abstractMessageMediator.Send(_userId, to, mm);
        }

        /// <summary>
        /// 接受Message（由中介者调用）
        /// </summary>
        /// <param name="from">来自UserId</param>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public abstract string Insert(string from, MessageModel mm);
    }
}
