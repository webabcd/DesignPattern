using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    /// <summary>
    /// 模板方法抽象类
    /// </summary>
    public abstract class AbstractMessageTemplate
    {
        /// <summary>
        /// UserId
        /// </summary>
        protected string _userId;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId">UserId</param>
        public AbstractMessageTemplate(string userId)
        {
            this._userId = userId;
        }
       
        /// <summary>
        /// 验证用户是否合法
        /// </summary>
        /// <returns></returns>
        public virtual bool ValidateUser()
        {
            if (this._userId == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 获取MessageModel列表
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// 模板方法：先验证用户是否合法，再获取MessageModel列表
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> TemplateMethodGet()
        {
            if (ValidateUser())
            {
                return Get();
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
