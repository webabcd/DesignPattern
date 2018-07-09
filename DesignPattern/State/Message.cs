using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// Context类
    /// </summary>
    public class Message
    {
        /// <summary>
        /// 类型为状态模式抽象类的私有变量
        /// </summary>
        private AbstractMessageState _abstractMessageState;

        /// <summary>
        /// 类型为状态模式抽象类的属性
        /// </summary>
        public AbstractMessageState AbstractMessageState
        {
            get { return _abstractMessageState; }
            set { _abstractMessageState = value; }
        }       

        /// <summary>
        /// UserId私有变量
        /// </summary>
        private string _userId;

        /// <summary>
        /// UserId
        /// </summary>
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userId">UserId</param>
        public Message(string userId)
        {
            this._userId = userId;

            _abstractMessageState = new XmlMessage(this);
        }

        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            // 修改状态
            _abstractMessageState.StateChangeCheck();

            return _abstractMessageState.Get();
        }

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            // 修改状态
            _abstractMessageState.StateChangeCheck();

            return _abstractMessageState.Insert(mm);
        }
    }
}
