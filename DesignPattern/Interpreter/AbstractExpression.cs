using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    /// <summary>
    /// ����ʽ��AbstractExpression��
    /// </summary>
    public abstract class AbstractExpression
    {
        /// <summary>
        /// ����Context�ķ���
        /// </summary>
        /// <param name="context">context</param>
        public void Interpret(Context context)
        {
            if (String.IsNullOrEmpty(context.Input))
            {
                return;
            }

            context.Output += GetCSharp(context.Input);
        }

        /// <summary>
        /// ���������������Ӧ��C#����
        /// </summary>
        /// <param name="source">source</param>
        /// <returns></returns>
        private string GetCSharp(string source)
        {
            string csharp = "";
            string word = "";

            // ������������ȡ��Ҫ���͵Ĵ�
            word = GetWord(source);

            // ���ֵ����ҵ�word����Ӧ��C#����
            GetDictionary().TryGetValue(word, out csharp);

            return csharp;
        }

        /// <summary>
        /// ������������ȡ��Ҫ���͵Ĵ�
        /// </summary>
        /// <param name="source">source</param>
        /// <returns></returns>
        public abstract string GetWord(string source);

        /// <summary>
        /// ��ȡ�ֵ�
        /// </summary>
        /// <returns></returns>
        public abstract Dictionary<string, string> GetDictionary();
    }
}
