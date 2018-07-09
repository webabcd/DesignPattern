using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Builder
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
            Message m = new Message();

            AbstractMessageBuilder amb = new SqlMessageBuilder();
            m.Construct(amb, new MessageModel("插入", DateTime.Now));
            lblMsg.AppendLine(amb.Operation.GetResult());

            amb = new XmlMessageBuilder();
            m.Construct(amb, new MessageModel("插入", DateTime.Now));
            lblMsg.AppendLine(amb.Operation.GetResult());
        }
    }
}
