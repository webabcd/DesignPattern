using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    /// <summary>
    /// Facade��
    /// </summary>
    public class Message
    {
        private string _userId = "";

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userId">UserId</param>
        public Message(string userId)
        {
            this._userId = userId;
        }

        /// <summary>
        /// ��ȡMessage
        /// ����ʹ��User���Validate()������֤�û��Ƿ�Ϸ�
        /// Ȼ��ʹ��SqlMessage���Get()������ȡMessage
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            User u = new User();
            SqlMessage m = new SqlMessage();

            if (u.Validate(_userId))
            {
                return m.Get();
            }
            else
            {
                List<MessageModel> l = new List<MessageModel>();
                l.Add(new MessageModel("��Ȩ��ȡ", DateTime.Now));

                return l;
            }
        }
    }
}
