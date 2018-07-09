using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    /// <summary>
    /// ����Message�����ࣨColleague��
    /// </summary>
    public abstract class AbstractMessage
    {
        private AbstractMessageMediator _abstractMessageMediator;
        private string _userId;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="userId">UserId</param>
        public AbstractMessage(string userId)
        {
            this._userId = userId;
        }

        /// <summary>
        /// UserId
        /// </summary>
        public string UserId
        {
            get { return _userId; }
        }

        /// <summary>
        /// �н���
        /// </summary>
        public AbstractMessageMediator AbstractMessageMediator
        {
            get { return _abstractMessageMediator; }
            set { _abstractMessageMediator = value; }
        }

        /// <summary>
        /// ����Message���ɿͻ��˵��ã�
        /// </summary>
        /// <param name="to">���͵�UserId</param>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public string Send(string to, MessageModel mm)
        {
            return _abstractMessageMediator.Send(_userId, to, mm);
        }

        /// <summary>
        /// ����Message�����н��ߵ��ã�
        /// </summary>
        /// <param name="from">����UserId</param>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public abstract string Insert(string from, MessageModel mm);
    }
}
