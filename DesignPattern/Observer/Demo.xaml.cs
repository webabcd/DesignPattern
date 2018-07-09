using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Observer
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
            MessageSubject m = new MessageSubject(new MessageModel("插入Message", DateTime.Now));

            SqlMessage sqlMessage = new SqlMessage();
            XmlMessage xmlMessage = new XmlMessage();

            m.Attach(sqlMessage);
            m.Attach(xmlMessage);

            // 修改了 PublishTime 就会通知所有观察者
            // m.PublishTime = DateTime.Now;

            lblMsg.AppendLine(m.Notify());
        }
    }
}
