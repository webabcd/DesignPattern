using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// ��������(Handler)��ɫ
    /// </summary>
    public abstract class AbstractExecutor
    {
        /// <summary>
        /// ��������(Handler)��ɫ
        /// </summary>
        protected AbstractExecutor _executor;

        /// <summary>
        /// ��������������һ������
        /// </summary>
        /// <param name="executor"></param>
        public void SetSuccessor(AbstractExecutor executor)
        {
            this._executor = executor;
        }

        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns>ִ���ߣ����ݣ�ʱ��</returns>
        public abstract string Insert(MessageModel mm);
    }
}
