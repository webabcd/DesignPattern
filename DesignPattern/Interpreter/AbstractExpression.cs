using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    /// <summary>
    /// 抽象公式（AbstractExpression）
    /// </summary>
    public abstract class AbstractExpression
    {
        /// <summary>
        /// 解释Context的方法
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
        /// 获得输入内容所对应的C#代码
        /// </summary>
        /// <param name="source">source</param>
        /// <returns></returns>
        private string GetCSharp(string source)
        {
            string csharp = "";
            string word = "";

            // 从输入内容中取得要解释的词
            word = GetWord(source);

            // 从字典中找到word所对应的C#代码
            GetDictionary().TryGetValue(word, out csharp);

            return csharp;
        }

        /// <summary>
        /// 从输入内容中取得要解释的词
        /// </summary>
        /// <param name="source">source</param>
        /// <returns></returns>
        public abstract string GetWord(string source);

        /// <summary>
        /// 获取字典
        /// </summary>
        /// <returns></returns>
        public abstract Dictionary<string, string> GetDictionary();
    }
}
