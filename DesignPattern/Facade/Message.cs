using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    /// <summary>
    /// Facade类
    /// </summary>
    public class Message
    {
        private string _userId = "";

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId">UserId</param>
        public Message(string userId)
        {
            this._userId = userId;
        }

        /// <summary>
        /// 获取Message
        /// 首先使用User类的Validate()方法验证用户是否合法
        /// 然后使用SqlMessage类的Get()方法获取Message
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
                l.Add(new MessageModel("无权获取", DateTime.Now));

                return l;
            }
        }
    }
}
