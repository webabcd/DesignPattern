using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    /// <summary>
    /// 抽象中介者（Mediator）
    /// </summary>
    public abstract class AbstractMessageMediator
    {
        /// <summary>
        /// 注册一个操作Message的对象
        /// </summary>
        /// <param name="AbstractMessage">AbstractMessage</param>
        public abstract void Register(AbstractMessage AbstractMessage);

        /// <summary>
        /// 发送Message
        /// </summary>
        /// <param name="from">来自UserId</param>
        /// <param name="to">发送到UserId</param>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public abstract string Send(string from, string to, MessageModel mm);
    }
}
