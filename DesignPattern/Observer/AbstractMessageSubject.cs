using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    /// <summary>
    /// ����Message���⣨Subject��
    /// </summary>
    public abstract class AbstractMessageSubject
    {
        private MessageModel _messageModel;
        private List<IMessage> list = new List<IMessage>();

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        public AbstractMessageSubject(MessageModel mm)
        {
            this._messageModel = mm;
        }

        /// <summary>
        /// ���һ��ʵ��IMessage�ӿڵĶ���
        /// </summary>
        /// <param name="m">ʵ��IMessage�ӿڵĶ���</param>
        public void Attach(IMessage m)
        {
            list.Add(m);
        }

        /// <summary>
        /// �Ƴ�һ��ʵ��IMessage�ӿڵĶ���
        /// </summary>
        /// <param name="m">ʵ��IMessage�ӿڵĶ���</param>
        public void Detach(IMessage m)
        {
            list.Remove(m);
        }

        /// <summary>
        /// ֪ͨ���й۲���
        /// </summary>
        /// <returns></returns>
        public string Notify()
        {
            string s = "";
            foreach (IMessage i in list)
            {
                s += i.Insert(_messageModel);
                s += Environment.NewLine;
            }

            return s;
        }

        /// <summary>
        /// Message����ʱ��
        /// </summary>
        public DateTime PublishTime
        {
            get { return _messageModel.PublishTime; }
            set
            {
                _messageModel.PublishTime = value;
                Notify();
            }
        }
    }
}
