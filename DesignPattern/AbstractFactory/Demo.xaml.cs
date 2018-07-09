using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.AbstractFactory
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
            Message m = new Message(amf);
            lblMsg.AppendLine(m.Insert("admin", "Sql方式", DateTime.Now));

            amf = new XmlMessageFactory();
            m = new Message(amf);
            lblMsg.AppendLine(m.Insert("user", "Xml方式", DateTime.Now));
        }
    }
}
