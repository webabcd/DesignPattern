using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    /// <summary>
    /// Sql��ʽ����Message�ࣨProduct��
    /// </summary>
    public class SqlMessage : AbstractMessage
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="amm">AbstractMessageModel</param>
        /// <returns></returns>
        public override string Insert(AbstractMessageModel amm)
        {
            return "Sql��ʽ����Message���ʺţ�" + amm.UserId 
                + "�����ݣ�" + amm.Message 
                + "��ʱ�䣺" + amm.PublishTime.ToString();
        }
    }
}
