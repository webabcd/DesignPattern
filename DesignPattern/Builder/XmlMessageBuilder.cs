using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// XmlMessage�����ߣ�ConcreteBuilder��
    /// </summary>
    public class XmlMessageBuilder : AbstractMessageBuilder
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public XmlMessageBuilder()
            : base("xml")
        {
 
        }

        /// <summary>
        /// ����Xml���뷽��
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        public override void BuilderInsert(MessageModel mm)
        {
            base._operation["insert"] = "XmlMessage|Insert|"+mm.Message+"|"+mm.PublishTime.ToString()+"";
        }

        /// <summary>
        /// ����Xml��ȡ����
        /// </summary>
        public override void BuilderGet()
        {
            base._operation["get"] = "XmlMessage|Get";
        }
    }
}
