using System;
using System.Collections.Generic;
using System.Text;

using System.Reflection;
using Windows.UI.Xaml;

namespace DesignPattern.Builder
{
    /// <summary>
    /// 操作（Product）
    /// </summary>
    public class Operation
    {
        private string _type;
        private Dictionary<string, string> _dictionary;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="type">产品类型</param>
        public Operation(string type)
        {
            _dictionary = new Dictionary<string, string>();
            this._type = type;
        }

        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }

        /// <summary>
        /// 获得结果
        /// </summary>
        /// <returns></returns>
        public string GetResult()
        {
            Assembly assembly = Application.Current.GetType().GetTypeInfo().Assembly;

            MethodInfo methodGet = assembly.GetType("DesignPattern.Builder." + _dictionary["get"].Split('|')[0]).GetMethod(_dictionary["get"].Split('|')[1]);
            object objGet = methodGet.Invoke(Activator.CreateInstance(assembly.GetType("DesignPattern.Builder." + _dictionary["get"].Split('|')[0])), null);
            List<MessageModel> m = (List<MessageModel>)objGet;
            
            MethodInfo methodInsert = assembly.GetType("DesignPattern.Builder." + _dictionary["insert"].Split('|')[0]).GetMethod(_dictionary["insert"].Split('|')[1]);
            object objInsert = methodInsert.Invoke(Activator.CreateInstance(assembly.GetType("DesignPattern.Builder." + _dictionary["insert"].Split('|')[0])), new object[] { new MessageModel(_dictionary["insert"].Split('|')[2], Convert.ToDateTime(_dictionary["insert"].Split('|')[3])) });
            bool b = (bool)objInsert;

            return "类型为" + this._type + "的执行结果：\n" + b.ToString() + "\n" + m[0].Message + " " + m[0].PublishTime.ToString() + "\n";
        }
    }
}
