using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Adapter
{
    /// <summary>
    /// Ŀ�꣨Target����ɫ
    /// ����Message�Ľӿ�
    /// </summary>
    public interface IMessage
    {
        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        List<MessageModel> Select();

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        bool Add(MessageModel mm);
    }
}
