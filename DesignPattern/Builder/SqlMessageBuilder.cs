using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// SqlMessage建造者（ConcreteBuilder）
    /// </summary>
    public class SqlMessageBuilder : AbstractMessageBuilder
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SqlMessageBuilder()
            : base("sql")
        {
 
        }

        /// <summary>
        /// 建造Sql插入方法
        /// </summary>
        /// <param name="mm">Message实体对象</param>
        public override void BuilderInsert(MessageModel mm)
        {
            base._operation["insert"] = "SqlMessage|Insert|" + mm.Message + "|" + mm.PublishTime.ToString() + "";
        }

        /// <summary>
        /// 建造Sql获取方法
        /// </summary>
        public override void BuilderGet()
        {
            base._operation["get"] = "SqlMessage|Get";
        }
    }
}
