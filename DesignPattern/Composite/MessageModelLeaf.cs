using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    /// <summary>
    /// Message实体树叶（Leaf）
    /// </summary>
    public class MessageModelLeaf : MessageModelComponent
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">名称</param>
        /// <param name="mm">Message实体对象</param>
        public MessageModelLeaf(string name, MessageModel mm)
            : base(name, mm)
        {
            
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public override void Add(MessageModelComponent mmc)
        {
            throw new Exception("不能添加");
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public override void Remove(MessageModelComponent mmc)
        {
            throw new Exception("不能删除");
        }

        /// <summary>
        /// 获取
        /// </summary>
        /// <param name="indent">缩进数</param>
        /// <returns></returns>
        public override string GetData(int indent)
        {
            return new String('—', indent) + 
                "树叶名称：" + _name + 
                "；信息内容：" + _messageModel.Message + 
                Environment.NewLine;
        }
    }
}
