using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Flyweight
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
            string[] ary = new string[] { "xml", "sql" };

            MessageFactory messageFactory = new MessageFactory();

            foreach (string key in ary)
            {
                AbstractMessage messageObject = messageFactory.GetMessageObject(key);

                lblMsg.AppendLine(messageObject.Insert(new MessageModel("插入", DateTime.Now)).ToString());
                lblMsg.AppendLine(messageObject.Get()[0].Message + " " + messageObject.Get()[0].PublishTime.ToString());
            }
        }
    }
}
