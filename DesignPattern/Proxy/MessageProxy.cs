using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    /// <summary>
    /// ������
    /// </summary>
    public class MessageProxy : IMessage
    {
        SqlMessage _sqlMessage;

        /// <summary>
        /// ���캯��
        /// </summary>
        public MessageProxy()
        {
            _sqlMessage = new SqlMessage();
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            return _sqlMessage.Get();
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            return _sqlMessage.Insert(mm);
        }
    }
}
