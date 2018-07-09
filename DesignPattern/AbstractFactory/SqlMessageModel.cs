using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// SqlMessage实体类（Product）
    /// </summary>
    public class SqlMessageModel : AbstractMessageModel
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SqlMessageModel()
            : base()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <param name="msg">Message内容</param>
        /// <param name="pt">Message发布时间</param>
        public SqlMessageModel(string userId, string msg, DateTime pt)
            : base(msg, pt)
        {
            this._userId = userId;
        }

        private string _userId;
        /// <summary>
        /// Message内容
        /// </summary>
        public override string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
    }
}
