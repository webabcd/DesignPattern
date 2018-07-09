using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ChainOfResponsibility
{
    /// <summary>
    /// ���崦����(ConcreteHandler)��ɫ
    /// </summary>
    public class Employee : AbstractExecutor
    {
        /// <summary>
        /// ����Message
        /// </summary>
        /// <param name="mm">Messageʵ�����</param>
        /// <returns>ִ���ߣ����ݣ�ʱ��</returns>
        public override string Insert(MessageModel mm)
        {
            string rtn = "";

            // �������Ϣ�ַ���С��5
            if (mm.Message.Length < 5)
            {
                SqlMessage m = new SqlMessage();

                if (m.Insert(mm))
                {
                    rtn = "ִ���ߣ���Ա" + " ���ݣ�" + mm.Message + " ʱ�䣺" + mm.PublishTime.ToString();
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
