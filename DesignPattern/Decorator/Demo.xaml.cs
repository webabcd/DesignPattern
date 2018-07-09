using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Decorator
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
            AbstractMessage message = new SqlMessage();

            AbstractMessageWrapper amr = new CheckUserWrapper(message);
            lblMsg.AppendLine(amr.Get()[0].Message + " " + amr.Get()[0].PublishTime.ToString());

            AbstractMessageWrapper amr2 = new CheckInputWrapper(message);
            lblMsg.AppendLine(amr2.Get()[0].Message + " " + amr2.Get()[0].PublishTime.ToString());

            AbstractMessageWrapper amr3 = new CheckUserWrapper(message);
            AbstractMessageWrapper amr4 = new CheckInputWrapper(amr3);
            lblMsg.AppendLine(amr4.Get()[0].Message + " " + amr4.Get()[0].PublishTime.ToString());
        }
    }
}
