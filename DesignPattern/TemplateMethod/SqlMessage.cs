using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    /// <summary>
    /// Sql��ʽ����Message
    /// </summary>
    public class SqlMessage : AbstractMessageTemplate
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userId">UserId</param>
        public SqlMessage(string userId)
            : base(userId)
        { 
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("SQL��ʽ��ȡMessage", DateTime.Now));

            return l;
        }
    }
}
