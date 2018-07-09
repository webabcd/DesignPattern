using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    /// <summary>
    /// Sql方式操作Message
    /// </summary>
    public class SqlMessage
    {
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("SQL方式获取Message", DateTime.Now));

            return l;
        }
    }
}
