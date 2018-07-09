using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// ����Message�����ࣨElement��
    /// </summary>
    public abstract class Message : AbstractElement
    {
        private MessageModel _messageModel;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        public Message(MessageModel mm)
        {
            this._messageModel = mm;
        }

        /// <summary>
        /// Messageʵ�����
        /// </summary>
        public MessageModel MessageModel
        {
            get { return _messageModel; }
            set { _messageModel = value; }
        }

        /// <summary>
        /// ִ�г�������ߵ�Visit()�������Ӷ�ִ�г���Ԫ�صķ�����
        /// </summary>
        /// <param name="abstractVisitor">���������</param>
        /// <returns></returns>
        public override string Accept(AbstractVisitor abstractVisitor)
        {
            return abstractVisitor.Visit(this);
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// ����Message
        /// </summary>
        /// <returns></returns>
        public abstract bool Insert();
    }
}
