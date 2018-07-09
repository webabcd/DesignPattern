using System;
using System.Collections.Generic;
using System.Text;

using System.Text.RegularExpressions;

namespace DesignPattern.Interpreter
{
    /// <summary>
    /// 终端公式（TerminalExpression）分析与数据库相关的
    /// </summary>
    public class DatabaseExpression : AbstractExpression
    {
        /// <summary>
        /// 从输入内容中取得要解释的词
        /// </summary>
        /// <param name="source">source</param>
        /// <returns></returns>
        public override string GetWord(string source)
        {
            MatchCollection mc;
            Regex r = new Regex(@"\{(.*)\}");
            mc = r.Matches(source);

            return mc[0].Groups[1].Value;
        }

        /// <summary>
        /// 获取与数据库相关的字典
        /// </summary>
        /// <returns></returns>
        public override Dictionary<string, string> GetDictionary()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            d.Add("数据库", "Sql");

            return d;
        }
    }
}
