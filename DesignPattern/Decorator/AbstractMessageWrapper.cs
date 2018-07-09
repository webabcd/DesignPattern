using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Decorator
{
    /// <summary>
    /// װ��AbstractMessage��Decorator��
    /// </summary>
    public abstract class AbstractMessageWrapper : AbstractMessage
    {
        private AbstractMessage _abstractMessage;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="abstractMessage">AbstractMessage</param>
        public AbstractMessageWrapper(AbstractMessage abstractMessage)
        {
            this._abstractMessage = abstractMessage;
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public override List<MessageModel> Get()
        {
            return _abstractMessage.Get();
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public override bool Insert(MessageModel mm)
        {
            return _abstractMessage.Insert(mm);
        }
    }
}
