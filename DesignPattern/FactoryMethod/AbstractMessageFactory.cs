using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// ����Message������Creator��
    /// </summary>
    public abstract class AbstractMessageFactory
    {
        // An Operation

        /// <summary>
        /// ��������
        /// </summary>
        /// <returns>AbstractMessage</returns>
        public abstract AbstractMessage CreateMessage();
    }
}
