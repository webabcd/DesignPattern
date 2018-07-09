using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Prototype
{
    /// <summary>
    /// 深拷贝
    /// </summary>
    public class DeepCopy : ICloneable
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DeepCopy()
        {
            
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public DeepCopy(MessageModel mm)
        {
            _mm = mm;
        }

        /// <summary>
        /// 实现ICloneable的Clone()方法
        /// </summary>
        /// <returns></returns>
        public Object Clone()
        {
            return new DeepCopy(new MessageModel(_mm.Message, _mm.PublishTime));
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
