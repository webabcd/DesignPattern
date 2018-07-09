using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// Sql方式操作Message类（Product）
    /// </summary>
    public class SqlMessage : AbstractMessage
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="amm">AbstractMessageModel</param>
        /// <returns></returns>
        public override string Insert(AbstractMessageModel amm)
        {
            return "Sql方式插入Message。帐号：" + amm.UserId 
                + "；内容：" + amm.Message 
                + "；时间：" + amm.PublishTime.ToString();
        }
    }
}
