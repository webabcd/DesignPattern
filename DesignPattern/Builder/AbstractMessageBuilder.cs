using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// ����Message�����ߣ�Builder��
    /// </summary>
    public abstract class AbstractMessageBuilder
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="type">��Ʒ����</param>
        public AbstractMessageBuilder(string type)
        {
            this._operation = new Operation(type);
        }

        /// <summary>
        /// ������Product��
        /// </summary>
        protected Operation _operation;
        /// <summary>
        /// ������Product��
        /// </summary>
        public Operation Operation
        {
            get { return _operation; }
            set { _operation = value; }
        }

        /// <summary>
        /// ������뷽��
        /// </summary>
        /// <param name="mm"></param>
        abstract public void BuilderInsert(MessageModel mm);

        /// <summary>
        /// �����ȡ����
        /// </summary>
        abstract public void BuilderGet();
    }
}
