using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    /// <summary>
    /// �û������
    /// </summary>
    public class User
    {
        /// <summary>
        /// ��֤�û��Ƿ�Ϸ�
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <returns></returns>
        public bool Validate(string userId)
        {
            if (userId == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
