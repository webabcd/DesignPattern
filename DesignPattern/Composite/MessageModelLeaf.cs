using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Composite
{
    /// <summary>
    /// Messageʵ����Ҷ��Leaf��
    /// </summary>
    public class MessageModelLeaf : MessageModelComponent
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="name">����</param>
        /// <param name="mm">Messageʵ�����</param>
        public MessageModelLeaf(string name, MessageModel mm)
            : base(name, mm)
        {
            
        }

        /// <summary>
        /// ���
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public override void Add(MessageModelComponent mmc)
        {
            throw new Exception("�������");
        }

        /// <summary>
        /// ɾ��
        /// </summary>
        /// <param name="mmc">MessageModelComponent</param>
        public override void Remove(MessageModelComponent mmc)
        {
            throw new Exception("����ɾ��");
        }

        /// <summary>
        /// ��ȡ
        /// </summary>
        /// <param name="indent">������</param>
        /// <returns></returns>
        public override string GetData(int indent)
        {
            return new String('��', indent) + 
                "��Ҷ���ƣ�" + _name + 
                "����Ϣ���ݣ�" + _messageModel.Message + 
                Environment.NewLine;
        }
    }
}
