using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 抽象Message建造者（Builder）
    /// </summary>
    public abstract class AbstractMessageBuilder
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type">产品类型</param>
        public AbstractMessageBuilder(string type)
        {
            this._operation = new Operation(type);
        }

        /// <summary>
        /// 操作（Product）
        /// </summary>
        protected Operation _operation;
        /// <summary>
        /// 操作（Product）
        /// </summary>
        public Operation Operation
        {
            get { return _operation; }
            set { _operation = value; }
        }

        /// <summary>
        /// 建造插入方法
        /// </summary>
        /// <param name="mm"></param>
        abstract public void BuilderInsert(MessageModel mm);

        /// <summary>
        /// 建造获取方法
        /// </summary>
        abstract public void BuilderGet();
    }
}
