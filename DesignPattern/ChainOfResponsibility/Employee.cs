using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 具体处理者(ConcreteHandler)角色
    /// </summary>
    public class Employee : AbstractExecutor
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns>执行者；内容；时间</returns>
        public override string Insert(MessageModel mm)
        {
            string rtn = "";

            // 插入的信息字符数小于5
            if (mm.Message.Length < 5)
            {
                SqlMessage m = new SqlMessage();

                if (m.Insert(mm))
                {
                    rtn = "执行者：雇员" + " 内容：" + mm.Message + " 时间：" + mm.PublishTime.ToString();
                }
            }
            // 否则让上级去执行
            else if (base._executor != null)
            {
                rtn = _executor.Insert(mm);
            }

            return rtn;
        }
    }
}
