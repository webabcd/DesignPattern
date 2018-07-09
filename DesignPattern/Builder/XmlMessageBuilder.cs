using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// XmlMessage建造者（ConcreteBuilder）
    /// </summary>
    public class XmlMessageBuilder : AbstractMessageBuilder
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public XmlMessageBuilder()
            : base("xml")
        {
 
        }

        /// <summary>
        /// 建造Xml插入方法
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public override void BuilderInsert(MessageModel mm)
        {
            base._operation["insert"] = "XmlMessage|Insert|"+mm.Message+"|"+mm.PublishTime.ToString()+"";
        }

        /// <summary>
        /// 建造Xml获取方法
        /// </summary>
        public override void BuilderGet()
        {
            base._operation["get"] = "XmlMessage|Get";
        }
    }
}
