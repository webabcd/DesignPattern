using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// ��������Adapter����ɫ
    /// ����������
    /// ��Դ���䵽�����
    /// </summary>
    public class Message2 : IMessage
    {
        private SqlMessage _sqlMessage;

        /// <summary>
        /// ���캯��
        /// </summary>
        public Message2()
        {
            _sqlMessage = new SqlMessage();
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Select()
        {
            return _sqlMessage.Get();
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public bool Add(MessageModel mm)
        {
            return _sqlMessage.Insert(mm);
        }
    }
}
