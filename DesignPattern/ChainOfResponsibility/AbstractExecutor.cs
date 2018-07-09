using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 抽象处理者(Handler)角色
    /// </summary>
    public abstract class AbstractExecutor
    {
        /// <summary>
        /// 抽象处理者(Handler)角色
        /// </summary>
        protected AbstractExecutor _executor;

        /// <summary>
        /// 设置责任链的上一级对象
        /// </summary>
        /// <param name="executor"></param>
        public void SetSuccessor(AbstractExecutor executor)
        {
            this._executor = executor;
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns>执行者；内容；时间</returns>
        public abstract string Insert(MessageModel mm);
    }
}
