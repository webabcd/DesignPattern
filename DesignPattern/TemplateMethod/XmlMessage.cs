using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    /// <summary>
    /// Xml��ʽ����Message
    /// </summary>
    public class XmlMessage : AbstractMessageTemplate
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userId">UserId</param>
        public XmlMessage(string userId)
            : base(userId)
        {
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("XML��ʽ��ȡMessage", DateTime.Now));

            return l;
        }
    }
}
