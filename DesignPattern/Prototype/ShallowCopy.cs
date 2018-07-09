using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    /// <summary>
    /// 浅拷贝
    /// </summary>
    public class ShallowCopy : ICloneable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ShallowCopy()
        {
            
        }

        /// <summary>
        /// 实现ICloneable的Clone()方法
        /// </summary>
        /// <returns></returns>
        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        private MessageModel _mm;
        /// <summary>
        /// Message实体对象
        /// </summary>
        public MessageModel MessageModel
        {
            get { return _mm; }
            set { _mm = value; }
        }
    }
}
