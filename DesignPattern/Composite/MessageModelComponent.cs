using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    /// <summary>
    /// ����Messageʵ�幹����Component��
    /// </summary>
    public abstract class MessageModelComponent
    {
        /// <summary>
        /// Messageʵ�����
        /// </summary>
        protected MessageModel _messageModel;

        /// <summary>
        /// ����
        /// </summary>
        protected string _name;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">����</param>
        /// <param name="mm">Messageʵ�����</param>
        public MessageModelComponent(string name, MessageModel mm)
        {
            this._name = name;
            this._messageModel = mm;
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">����</param>
        public MessageModelComponent(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// ���
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public abstract void Add(MessageModelComponent mmc);

        /// <summary>
        /// ɾ��
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public abstract void Remove(MessageModelComponent mmc);

        /// <summary>
        /// ��ȡ
        /// </summary>
        /// <param name="indent">������</param>
        /// <returns></returns>
        public abstract string GetData(int indent);
    }
}
