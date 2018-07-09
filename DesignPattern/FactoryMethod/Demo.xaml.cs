using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.FactoryMethod
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
            AbstractMessageFactory amf = new SqlMessageFactory();
            AbstractMessage am = amf.CreateMessage();
            lblMsg.AppendLine(am.Insert(new MessageModel("插入", DateTime.Now)).ToString());
            lblMsg.AppendLine(am.Get()[0].Message + " " + am.Get()[0].PublishTime.ToString());

            amf = new XmlMessageFactory();
            am = amf.CreateMessage();
            lblMsg.AppendLine(am.Insert(new MessageModel("插入", DateTime.Now)).ToString());
            lblMsg.AppendLine(am.Get()[0].Message + " " + am.Get()[0].PublishTime.ToString());
        }
    }
}
