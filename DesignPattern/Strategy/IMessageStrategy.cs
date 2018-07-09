using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    /// <summary>
    /// ���Խӿ�
    /// </summary>
    public interface IMessageStrategy
    {
        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        List<MessageModel> Get();

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        bool Insert(MessageModel mm);
    }
}
