using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// ��������Adapter����ɫ
    /// ��������
    /// ��Դ���䵽�����
    /// </summary>
    public class Message : SqlMessage, IMessage
    {
        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Select()
        {
            return base.Get();
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public bool Add(MessageModel mm)
        {
            return base.Insert(mm);
        }
    }
}
