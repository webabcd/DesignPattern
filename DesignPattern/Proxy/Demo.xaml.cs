using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Proxy
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
            MessageProxy m = new MessageProxy();
            lblMsg.AppendLine(m.Insert(new MessageModel("插入", DateTime.Now)).ToString());
            lblMsg.AppendLine(m.Get()[0].Message + " " + m.Get()[0].PublishTime.ToString());
        }
    }
}
