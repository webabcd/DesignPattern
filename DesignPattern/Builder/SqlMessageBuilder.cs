using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    /// <summary>
    /// SqlMessage�����ߣ�ConcreteBuilder��
    /// </summary>
    public class SqlMessageBuilder : AbstractMessageBuilder
    {
        /// <summary>
        /// ���캯��
        /// </summary>
        public SqlMessageBuilder()
            : base("sql")
        {
 
        }

        /// <summary>
        /// ����Sql���뷽��
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        public override void BuilderInsert(MessageModel mm)
        {
            base._operation["insert"] = "SqlMessage|Insert|" + mm.Message + "|" + mm.PublishTime.ToString() + "";
        }

        /// <summary>
        /// ����Sql��ȡ����
        /// </summary>
        public override void BuilderGet()
        {
            base._operation["get"] = "SqlMessage|Get";
        }
    }
}
