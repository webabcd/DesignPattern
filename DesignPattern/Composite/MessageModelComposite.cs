using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    /// <summary>
    /// Message实体树枝（Composite）
    /// </summary>
    public class MessageModelComposite : MessageModelComponent
    {
        private List<MessageModelComponent> _list;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">名称</param>
        public MessageModelComposite(string name)
            : base(name)
        {
            _list = new List<MessageModelComponent>();
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public override void Add(MessageModelComponent mmc)
        {
            _list.Add(mmc);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public override void Remove(MessageModelComponent mmc)
        {
            _list.Remove(mmc);
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="indent">缩进数</param>
        /// <returns></returns>
        public override string GetData(int indent)
        {
            string s = new String('—', indent) + 
                "树枝名称：" + _name + 
                Environment.NewLine;

            foreach (MessageModelComponent mmc in _list)
            {
                s += mmc.GetData(indent + 2);
            }

            return s;
        }
    }
}
