using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;
using System.Collections.Generic;
using System.Reflection;

namespace DesignPattern.Interpreter
{
    public sealed partial class Demo : Page
    {
        public Demo()
        {
            this.InitializeComponent();

            this.Loaded += Demo_Loaded;
        }

        private void Demo_Loaded(object sender, RoutedEventArgs e)
        {
            string chinese = "{数据库}[信息](获取)";
            Context context = new Context(chinese);

            List<AbstractExpression> l = new List<AbstractExpression>();
            l.Add(new DatabaseExpression());
            l.Add(new ObjectExpression());
            l.Add(new MethodExpression());

            foreach (AbstractExpression exp in l)
            {
                exp.Interpret(context);
            }

            Assembly assembly = Application.Current.GetType().GetTypeInfo().Assembly;
            MethodInfo method = assembly.GetType("DesignPattern.Interpreter." + context.Output.Split('.')[0]).GetMethod(context.Output.Split('.')[1].Replace("()", ""));
            object obj = method.Invoke(null, null);

            List<MessageModel> m = (List<MessageModel>)obj;

            lblMsg.AppendLine("中文语法：" + chinese);
            lblMsg.AppendLine("解释后的C#代码：" + context.Output);
            lblMsg.AppendLine("执行结果：" + m[0].Message + " " + m[0].PublishTime.ToString());
        }
    }
}
