using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// ��չ���û���֤�Ĺ��ܣ�ConcreteDecorator��
    /// </summary>
    public class CheckUserWrapper : AbstractMessageWrapper
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="abstractMessage">AbstractMessage</param>
        public CheckUserWrapper(AbstractMessage abstractMessage)
            : base(abstractMessage)
        {
            
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            List<MessageModel> l = base.Get();

            foreach (MessageModel mm in l)
            {
                mm.Message += "�������û���֤��";
            }

            return l;
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public override bool Insert(MessageModel mm)
        {
            // ��������չ����

            return base.Insert(mm);
        }

    }
}
