using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    /// <summary>
    /// ǳ����
    /// </summary>
    public class ShallowCopy : ICloneable
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public ShallowCopy()
        {
            
        }

        /// <summary>
        /// ʵ��ICloneable��Clone()����
        /// </summary>
        /// <returns></returns>
        public Object Clone()
        {
            return this.MemberwiseClone();
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
