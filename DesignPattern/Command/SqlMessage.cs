using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    /// <summary>
    /// 接收者（Receiver）角色
    /// Sql方式操作Message
    /// </summary>
    public class SqlMessage
    {
        /// <summary>
        /// 操作
        /// </summary>
        /// <param name="action">操作的方法</param>
        /// <param name="mm">Message实体对象</param>
        public void Operation(Action action, MessageModel mm)
        {
            switch (action)
            {
                case Action.Insert : 
                    Insert(mm); 
                    break;
                case Action.Delete :
                    Delete(mm);
                    break;
            }
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        private void Insert(MessageModel mm)
        {
            // 代码略
        }

        /// <summary>
        /// 删除Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        private void Delete(MessageModel mm)
        {
            // 代码略
        }
    }
}
