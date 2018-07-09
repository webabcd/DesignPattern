using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    /// <summary>
    /// Messageʵ����֦��Composite��
    /// </summary>
    public class MessageModelComposite : MessageModelComponent
    {
        private List<MessageModelComponent> _list;

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">����</param>
        public MessageModelComposite(string name)
            : base(name)
        {
            _list = new List<MessageModelComponent>();
        }

        /// <summary>
        /// ���
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public override void Add(MessageModelComponent mmc)
        {
            _list.Add(mmc);
        }

        /// <summary>
        /// ɾ��
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public override void Remove(MessageModelComponent mmc)
        {
            _list.Remove(mmc);
        }

        /// <summary>
        /// ��ȡ
        /// </summary>
        /// <param name="indent">������</param>
        /// <returns></returns>
        public override string GetData(int indent)
        {
            string s = new String('��', indent) + 
                "��֦���ƣ�" + _name + 
                Environment.NewLine;

            foreach (MessageModelComponent mmc in _list)
            {
                s += mmc.GetData(indent + 2);
            }

            return s;
        }
    }
}
