using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// Xml��ʽ����Message
    /// </summary>
    public class XmlMessage : AbstractMessageState
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="message">Context���Ͳ���</param>
        public XmlMessage(Message message)
        {
            this._message = message;
        }

        /// <summary>
        /// �ı�״̬
        /// </summary>
        public override void StateChangeCheck()
        {
            // ���UserId��admin��任״̬ΪSqlMessage
            if (this._message.UserId == "admin")
            {
                this._message.AbstractMessageState = new SqlMessage(this._message);
            }
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

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public override bool Insert(MessageModel mm)
        {
            // ������
            return true;
        }
    }
}
