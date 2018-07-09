using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    /// <summary>
    /// 请求者（Invoker）角色
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 命令集合（保存每次操作）
        /// </summary>
        private List<ICommand> _listCommand = new List<ICommand>();

        /// <summary>
        /// 命令集合中当前要执行的命令的索引
        /// </summary>
        private int current = 0;

        /// <summary>
        /// 执行Sql
        /// </summary>
        /// <param name="action">操作的方法</param>
        /// <param name="mm">Message实体对象</param>
        /// <returns>操作的方法及操作的信息</returns>
        public string Do(Action action, MessageModel mm)
        {
            string rtn = "";

            ICommand cmd = new SqlMessageCommand(action, mm);
            rtn = cmd.Execute();

            _listCommand.Add(cmd);
            current++;

            return rtn;
        }

        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="levels">执行撤销操作的次数</param>
        /// <returns>操作的方法及操作的信息（用空格分开多条记录）</returns>
        public string Undo(int levels)
        {
            string rtn = "";

            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    ICommand cmd = _listCommand[--current];
                    rtn += cmd.UnExecute() + " ";
                }
            }

            return rtn;
        }

        /// <summary>
        /// 重复
        /// </summary>
        /// <param name="levels">执行重复操作的次数</param>
        /// <returns>操作的方法及操作的信息（用空格分开多条记录）</returns>
        public string Redo(int levels)
        {
            string rtn = "";

            for (int i = 0; i < levels; i++)
            {
                if (current < _listCommand.Count - 1)
                {
                    ICommand cmd = _listCommand[current++];
                    rtn += cmd.UnExecute() + " ";
                }
            }

            return rtn;
        }
    }
}
