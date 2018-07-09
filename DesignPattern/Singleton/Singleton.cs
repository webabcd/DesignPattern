using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// ����ʵ�ֵ���ģʽ
    /// </summary>
    /// <typeparam name="T">��Ҫʵ�ֵ�������</typeparam>
    public class Singleton<T> where T : new()
    {
        /// <summary>
        /// �������ʵ��
        /// </summary>
        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }

        class SingletonCreator
        {
            internal static readonly T instance = new T();
        }
    }
}
