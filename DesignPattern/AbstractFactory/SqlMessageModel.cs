using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// SqlMessageʵ���ࣨProduct��
    /// </summary>
    public class SqlMessageModel : AbstractMessageModel
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public SqlMessageModel()
            : base()
        {

        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <param name="msg">Message����</param>
        /// <param name="pt">Message����ʱ��</param>
        public SqlMessageModel(string userId, string msg, DateTime pt)
            : base(msg, pt)
        {
            this._userId = userId;
        }

        private string _userId;
        /// <summary>
        /// Message����
        /// </summary>
        public override string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
    }
}
