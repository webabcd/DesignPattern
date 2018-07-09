using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Visitor
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
            DesignPattern.Visitor.Messages m = new DesignPattern.Visitor.Messages();

            m.Attach(new SqlMessage(new MessageModel("插入", DateTime.Now)));
            m.Attach(new XmlMessage(new MessageModel("插入", DateTime.Now)));

            lblMsg.AppendLine(m.Accept(new InsertVisitor()));
            lblMsg.AppendLine(m.Accept(new GetVisitor()));
        }
    }
}
