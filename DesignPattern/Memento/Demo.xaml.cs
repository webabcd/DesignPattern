using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;
using System.Threading.Tasks;

namespace DesignPattern.Memento
{
    public sealed partial class Demo : Page
    {
        public Demo()
        {
            this.InitializeComponent();

            this.Loaded += Demo_Loaded;
        }

        private async void Demo_Loaded(object sender, RoutedEventArgs e)
        {
            SqlMessage m = new SqlMessage();
            m.Message = "Message内容";
            m.PublishTime = DateTime.Now;

            MessageModelCaretaker mmc = new MessageModelCaretaker();
            mmc.MessageModel = m.SaveMemento();

            bool bln = false;
            while (!bln)
            {
                bln = m.Insert(new MessageModel(m.Message, m.PublishTime));

                lblMsg.AppendLine(m.Message + " " + m.PublishTime.ToString() + " " + bln.ToString());

                if (!bln)
                {
                    await Task.Delay(1000);

                    m.RestoreMemento(mmc.MessageModel);
                    m.PublishTime = DateTime.Now;
                }
            }
        }
    }
}
