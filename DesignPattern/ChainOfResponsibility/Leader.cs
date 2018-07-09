using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// ��������(Handler)��ɫ
    /// </summary>
    public class Leader : AbstractExecutor
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns>ִ���ߣ����ݣ�ʱ��</returns>
        public override string Insert(MessageModel mm)
        {
            string rtn = "";

            // �������Ϣ�ַ���С��10
            if (mm.Message.Length < 10)
            {
                SqlMessage m = new SqlMessage();

                if (m.Insert(mm))
                {
                    rtn = "ִ���ߣ�����" + " ���ݣ�" + mm.Message + " ʱ�䣺" + mm.PublishTime.ToString();
                }
            }
            // �������ϼ�ȥִ��
            else if (base._executor != null)
            {
                rtn = _executor.Insert(mm);
            }

            return rtn;
        }
    }
}
