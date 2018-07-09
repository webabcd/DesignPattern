using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    /// <summary>
    /// ģ�巽��������
    /// </summary>
    public abstract class AbstractMessageTemplate
    {
        /// <summary>
        /// UserId
        /// </summary>
        protected string _userId;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userId">UserId</param>
        public AbstractMessageTemplate(string userId)
        {
            this._userId = userId;
        }
       
        /// <summary>
        /// ��֤�û��Ƿ�Ϸ�
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
        /// ��ȡMessageModel�б�
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// ģ�巽��������֤�û��Ƿ�Ϸ����ٻ�ȡMessageModel�б�
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
                l.Add(new MessageModel("��Ȩ��ȡ", DateTime.Now));

                return l;
            }
        }
    }
}
