using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// XmlMessage实体类（Product）
    /// </summary>
    public class XmlMessageModel : AbstractMessageModel
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public XmlMessageModel()
            : base()
        {

        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <param name="msg">Message内容</param>
        /// <param name="pt">Message发布时间</param>
        public XmlMessageModel(string userId, string msg, DateTime pt)
            : base (msg, pt)
        {
            this._userId = userId;
        }

        private string _userId;
        /// <summary>
        /// Message内容
        /// </summary>
        public override string UserId
        {
            // 解密算法后的值
            get { return _userId; } 

            // 加密算法后的值
            set { _userId = value; }
        }
    }
}
