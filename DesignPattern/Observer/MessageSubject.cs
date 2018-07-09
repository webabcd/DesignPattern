using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// Message���⣨ConcreteSubject��
    /// </summary>
    public class MessageSubject : AbstractMessageSubject
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        public MessageSubject(MessageModel mm)
            : base(mm)
        {
 
        }
    }
}
