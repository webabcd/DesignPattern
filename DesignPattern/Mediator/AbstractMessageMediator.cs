using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    /// <summary>
    /// �����н��ߣ�Mediator��
    /// </summary>
    public abstract class AbstractMessageMediator
    {
        /// <summary>
        /// ע��һ������Message�Ķ���
        /// </summary>
        /// <param name="AbstractMessage">AbstractMessage</param>
        public abstract void Register(AbstractMessage AbstractMessage);

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="from">����UserId</param>
        /// <param name="to">���͵�UserId</param>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns></returns>
        public abstract string Send(string from, string to, MessageModel mm);
    }
}
