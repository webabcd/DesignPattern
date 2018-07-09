using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// 操作Message抽象类（AbstractProduct）
    /// </summary>
    public abstract class AbstractMessage
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="amm">AbstractMessageModel</param>
        /// <returns></returns>
        public abstract string Insert(AbstractMessageModel amm);
    }
}
