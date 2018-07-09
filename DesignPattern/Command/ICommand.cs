using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    /// <summary>
    /// 命令（Command）角色
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 执行
        /// </summary>
        /// <returns>操作的方法及操作的信息</returns>
        string Execute();

        /// <summary>
        /// 取消执行
        /// </summary>
        /// <returns>操作的方法及操作的信息</returns>
        string UnExecute();
    }
}
