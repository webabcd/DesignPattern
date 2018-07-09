using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Interpreter
{
    /// <summary>
    /// Context
    /// </summary>
    public class Context
    {
        private string _input;
        private string _output;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="input">输入内容</param>
        public Context(string input)
        {
            this._input = input;
        }

        /// <summary>
        /// 输入内容
        /// </summary>
        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        /// <summary>
        /// 输出内容
        /// </summary>
        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }
}
