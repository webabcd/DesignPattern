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
        /// ���캯��
        /// </summary>
        /// <param name="input">��������</param>
        public Context(string input)
        {
            this._input = input;
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string Input
        {
            get { return _input; }
            set { _input = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        public string Output
        {
            get { return _output; }
            set { _output = value; }
        }
    }
}
