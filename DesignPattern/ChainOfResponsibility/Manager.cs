using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// ��������(Handler)��ɫ
    /// </summary>
    public class Manager : AbstractExecutor
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns>ִ���ߣ����ݣ�ʱ��</returns>
        public override string Insert(MessageModel mm)
        {
            string rtn = "";

            // �������Ϣ�ַ���С��15
            if (mm.Message.Length < 15)
            {
                SqlMessage m = new SqlMessage();

                if (m.Insert(mm))
                {
                    rtn = "ִ���ߣ�����" + " ���ݣ�" + mm.Message + " ʱ�䣺" + mm.PublishTime.ToString();
                }
            }
            else
            {
                rtn = "���������Message������Ҫ��";
            }

            return rtn;
        }
    }
}
