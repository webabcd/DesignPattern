using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    /// <summary>
    /// Sql��ʽ����Message��ConcreteColleague��
    /// </summary>
    public class SqlMessage : AbstractMessage
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userId">UserId</param>
        public SqlMessage(string userId)
            : base(userId)
        {

        }

        /// <summary>
        /// ����Message�����н��ߵ��ã�
        /// </summary>
        /// <param name="from">����UserId</param>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public override string Insert(string from, MessageModel mm)
        {
            return "Sql��ʽ����Message��" + from + "���͸�" + base.UserId + "��"
                + " - ���ݣ�" + mm.Message
                + " - ʱ�䣺" + mm.PublishTime.ToString();
        }
    }
}
