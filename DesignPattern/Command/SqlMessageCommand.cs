using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    /// <summary>
    /// 具体命令（ConcreteCommand）角色
    /// </summary>
    public class SqlMessageCommand : ICommand
    {
        /// <summary>
        /// 操作的方法
        /// </summary>
        private Action _action;

        /// <summary>
        /// Message实体对象
        /// </summary>
        private MessageModel _mm;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="action">操作的方法</param>
        /// <param name="mm">Message实体对象</param>
        public SqlMessageCommand(Action action, MessageModel mm)
        {
            this._action = action;
            this._mm = mm;
        }

        /// <summary>
        /// 执行
        /// </summary>
        /// <returns>操作的方法及操作的信息</returns>
        public string Execute()
        {
            new SqlMessage().Operation(_action, _mm);

            return _action.ToString() + "：" + _mm.Message;
        }

        /// <summary>
        /// 取消执行（调用一个方法，以决定取消执行的算法）
        /// </summary>
        /// <returns>操作的方法及操作的信息</returns>
        public string UnExecute()
        {
            _action = GetUndoAction(_action);
            new SqlMessage().Operation(_action, _mm);

            return _action.ToString() + "：" + _mm.Message;
        }

        /// <summary>
        /// 获得取消执行的算法
        /// </summary>
        /// <param name="action">操作的方法</param>
        /// <returns></returns>
        private Action GetUndoAction(Action action)
        {
            Action undo;

            switch (action)
            {
                case Action.Insert : 
                    undo = Action.Delete; 
                    break;
                case Action.Delete :
                    undo = Action.Insert;
                    break;
                // 这句没啥用
                default :
                    undo = Action.Insert;
                    break;
            }

            return undo;
        }
    }
}
