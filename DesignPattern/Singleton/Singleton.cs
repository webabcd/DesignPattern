using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// 泛型实现单例模式
    /// </summary>
    /// <typeparam name="T">需要实现单例的类</typeparam>
    public class Singleton<T> where T : new()
    {
        /// <summary>
        /// 返回类的实例
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
