using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Facade
{
    /// <summary>
    /// 用户相关类
    /// </summary>
    public class User
    {
        /// <summary>
        /// 验证用户是否合法
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
