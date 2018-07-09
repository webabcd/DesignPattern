using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    /// <summary>
    /// ����Message�����ࣨFlyweight��
    /// </summary>
    public abstract class AbstractMessage
    {
        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public abstract bool Insert(MessageModel mm);
    }
}
