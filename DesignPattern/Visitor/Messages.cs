using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// Message���ϣ�ObjectStructure��
    /// </summary>
    public class Messages
    {
        private List<Message> _list = new List<Message>();

        /// <summary>
        /// ���һ��Message����
        /// </summary>
        /// <param name="message">Message����</param>
        public void Attach(Message message)
        {
            _list.Add(message);
        }

        /// <summary>
        /// �Ƴ�һ��Message����
        /// </summary>
        /// <param name="message">Message����</param>
        public void Detach(Message message)
        {
            _list.Remove(message);
        }

        /// <summary>
        /// ִ�м���������Message�����Accept()������ִ�г�������ߵ�Visit()�������Ӷ�ִ�г���Ԫ�صķ�������
        /// </summary>
        /// <param name="abstractVisitor">���������</param>
        /// <returns></returns>
        public string Accept(AbstractVisitor abstractVisitor)
        {
            string s = "";
            foreach (Message m in _list)
            {
                s += m.Accept(abstractVisitor);
            }

            return s;
        }
    }
}
