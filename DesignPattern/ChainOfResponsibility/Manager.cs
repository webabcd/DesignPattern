using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// 抽象处理者(Handler)角色
    /// </summary>
    public class Manager : AbstractExecutor
    {
        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns>执行者；内容；时间</returns>
        public override string Insert(MessageModel mm)
        {
            string rtn = "";

            // 插入的信息字符数小于15
            if (mm.Message.Length < 15)
            {
                SqlMessage m = new SqlMessage();

                if (m.Insert(mm))
                {
                    rtn = "执行者：经理" + " 内容：" + mm.Message + " 时间：" + mm.PublishTime.ToString();
                }
            }
            else
            {
                rtn = "你所插入的Message不符合要求";
            }

            return rtn;
        }
    }
}
