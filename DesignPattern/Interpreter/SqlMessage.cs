using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    /// <summary>
    /// Sql��ʽ����Message
    /// </summary>
    public class SqlMessage
    {
        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public static List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("SQL��ʽ��ȡMessage", DateTime.Now));

            return l;
        }
    }
}
