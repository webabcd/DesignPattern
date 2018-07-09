using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    /// <summary>
    /// Context��
    /// </summary>
    public class Message
    {
        /// <summary>
        /// ����Ϊ״̬ģʽ�������˽�б���
        /// </summary>
        private AbstractMessageState _abstractMessageState;

        /// <summary>
        /// ����Ϊ״̬ģʽ�����������
        /// </summary>
        public AbstractMessageState AbstractMessageState
        {
            get { return _abstractMessageState; }
            set { _abstractMessageState = value; }
        }       

        /// <summary>
        /// UserId˽�б���
        /// </summary>
        private string _userId;

        /// <summary>
        /// UserId
        /// </summary>
        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userId">UserId</param>
        public Message(string userId)
        {
            this._userId = userId;

            _abstractMessageState = new XmlMessage(this);
        }

        /// <summary>
        /// ��ȡMessage
        /// </summary>
        /// <returns></returns>
        public List<MessageModel> Get()
        {
            // �޸�״̬
            _abstractMessageState.StateChangeCheck();

            return _abstractMessageState.Get();
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public bool Insert(MessageModel mm)
        {
            // �޸�״̬
            _abstractMessageState.StateChangeCheck();

            return _abstractMessageState.Insert(mm);
        }
    }
}
