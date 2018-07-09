using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    /// <summary>
    /// 抽象Message实体构件（Component）
    /// </summary>
    public abstract class MessageModelComponent
    {
        /// <summary>
        /// Message实体对象
        /// </summary>
        protected MessageModel _messageModel;

        /// <summary>
        /// 名称
        /// </summary>
        protected string _name;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="mm">Message实体对象</param>
        public MessageModelComponent(string name, MessageModel mm)
        {
            this._name = name;
            this._messageModel = mm;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">名称</param>
        public MessageModelComponent(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public abstract void Add(MessageModelComponent mmc);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public abstract void Remove(MessageModelComponent mmc);

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="indent">缩进数</param>
        /// <returns></returns>
        public abstract string GetData(int indent);
    }
}
