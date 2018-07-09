using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Visitor
{
    /// <summary>
    /// Message集合（ObjectStructure）
    /// </summary>
    public class Messages
    {
        private List<Message> _list = new List<Message>();

        /// <summary>
        /// 添加一个Message对象
        /// </summary>
        /// <param name="message">Message对象</param>
        public void Attach(Message message)
        {
            _list.Add(message);
        }

        /// <summary>
        /// 移除一个Message对象
        /// </summary>
        /// <param name="message">Message对象</param>
        public void Detach(Message message)
        {
            _list.Remove(message);
        }

        /// <summary>
        /// 执行集合内所有Message对象的Accept()方法（执行抽象访问者的Visit()方法（从而执行抽象元素的方法））
        /// </summary>
        /// <param name="abstractVisitor">抽象访问者</param>
        /// <returns></returns>
        public string Accept(AbstractVisitor abstractVisitor)
        {
            string s = "";
            foreach (Message m in _list)
            {
                s += m.Accept(abstractVisitor);
            }

            return s;
        }
    }
}
