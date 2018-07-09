using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// Sql��ʽ����Message
    /// </summary>
    public class SqlMessage : AbstractMessageState
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="message">Context���Ͳ���</param>
        public SqlMessage(Message message)
        {
            this._message = message;
        }

        /// <summary>
        /// �ı�״̬
        /// </summary>
        public override void StateChangeCheck()
        {

        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = new List<MessageModel>();
            l.Add(new MessageModel("SQL��ʽ��ȡMessage", DateTime.Now));

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
