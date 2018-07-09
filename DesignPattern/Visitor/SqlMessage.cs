using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// Sql��ʽ����Message��ConcreteElement��
    /// </summary>
    public class SqlMessage : Message
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        public SqlMessage(MessageModel mm)
            : base(mm)
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
        /// <returns></returns>
        public override bool Insert()
        {
            // ������
            return true;
        }
    }
}
