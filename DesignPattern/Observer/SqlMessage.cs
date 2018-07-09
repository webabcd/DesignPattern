using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// Sql��ʽ����Message��ConcreteObserver��
    /// </summary>
    public class SqlMessage : IMessage
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public string Insert(MessageModel mm)
        {
            return "sql��ʽ��" + mm.Message + " " + mm.PublishTime.ToString();
        } 
    }
}
