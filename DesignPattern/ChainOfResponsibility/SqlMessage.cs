using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// Sql方式操作Message
    /// </summary>
    public class SqlMessage
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            // 代码略
            return true;
        }
    }
}
