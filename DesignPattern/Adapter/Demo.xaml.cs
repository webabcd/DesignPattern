using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Adapter
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
            IMessage m;

            m = new Message();
            lblMsg.AppendLine("类适配器方式");
            lblMsg.AppendLine(m.Add(new MessageModel("插入", DateTime.Now)).ToString());
            lblMsg.AppendLine(m.Select()[0].Message + " " + m.Select()[0].PublishTime.ToString());
            lblMsg.AppendLine();

            m = new Message2();
            lblMsg.AppendLine("对象适配器方式");
            lblMsg.AppendLine(m.Add(new MessageModel("插入", DateTime.Now)).ToString());
            lblMsg.AppendLine(m.Select()[0].Message + " " + m.Select()[0].PublishTime.ToString());
        }
    }
}
