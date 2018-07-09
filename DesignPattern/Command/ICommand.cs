using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Command
{
    /// <summary>
    /// ���Command����ɫ
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// ִ��
        /// </summary>
        /// <returns>�����ķ�������������Ϣ</returns>
        string Execute();

        /// <summary>
        /// ȡ��ִ��
        /// </summary>
        /// <returns>�����ķ�������������Ϣ</returns>
        string UnExecute();
    }
}
