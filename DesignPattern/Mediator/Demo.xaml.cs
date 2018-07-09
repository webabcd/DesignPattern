using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Mediator
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
            AbstractMessageMediator messageMediator = new MessageMediator();

            AbstractMessage user1 = new SqlMessage("user1");
            AbstractMessage user2 = new SqlMessage("user2");
            AbstractMessage user3 = new XmlMessage("user3");
            AbstractMessage user4 = new XmlMessage("user4");

            messageMediator.Register(user1);
            messageMediator.Register(user2);
            messageMediator.Register(user3);
            messageMediator.Register(user4);

            lblMsg.AppendLine(user1.Send("user2", new MessageModel("你好！", DateTime.Now)));
            lblMsg.AppendLine(user2.Send("user1", new MessageModel("我不好！", DateTime.Now)));
            lblMsg.AppendLine(user1.Send("user2", new MessageModel("不好就不好吧。", DateTime.Now)));
            lblMsg.AppendLine(user3.Send("user4", new MessageModel("吃了吗？", DateTime.Now)));
            lblMsg.AppendLine(user4.Send("user3", new MessageModel("没吃，你请我？", DateTime.Now)));
            lblMsg.AppendLine(user3.Send("user4", new MessageModel("不请。", DateTime.Now)));
        }
    }
}
