using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.TemplateMethod
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
            AbstractMessageTemplate m = new XmlMessage("user");
            lblMsg.AppendLine(m.TemplateMethodGet()[0].Message + " " + m.TemplateMethodGet()[0].PublishTime.ToString());

            m = new SqlMessage("admin");
            lblMsg.AppendLine(m.TemplateMethodGet()[0].Message + " " + m.TemplateMethodGet()[0].PublishTime.ToString());
        }
    }
}
