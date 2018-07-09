using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.ChainOfResponsibility
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
            AbstractExecutor employee = new Employee();
            AbstractExecutor leader = new Leader();
            AbstractExecutor manager = new Manager();
            employee.SetSuccessor(leader);
            leader.SetSuccessor(manager);

            lblMsg.AppendLine(employee.Insert(new MessageModel("abcd", DateTime.Now)));
            lblMsg.AppendLine(employee.Insert(new MessageModel("abcdefgh", DateTime.Now)));
            lblMsg.AppendLine(employee.Insert(new MessageModel("abcdefghigkl", DateTime.Now)));
            lblMsg.AppendLine(employee.Insert(new MessageModel("abcdefghigklmnop", DateTime.Now)));
        }
    }
}
