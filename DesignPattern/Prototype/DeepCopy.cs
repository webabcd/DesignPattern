using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    /// <summary>
    /// ���
    /// </summary>
    public class DeepCopy : ICloneable
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public DeepCopy()
        {
            
        }

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        public DeepCopy(MessageModel mm)
        {
            _mm = mm;
        }

        /// <summary>
        /// ʵ��ICloneable��Clone()����
        /// </summary>
        /// <returns></returns>
        public Object Clone()
        {
            return new DeepCopy(new MessageModel(_mm.Message, _mm.PublishTime));
        }

        private MessageModel _mm;
        /// <summary>
        /// Messageʵ�����
        /// </summary>
        public MessageModel MessageModel
        {
            get { return _mm; }
            set { _mm = value; }
        }
    }
}
