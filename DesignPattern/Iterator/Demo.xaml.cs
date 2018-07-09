using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;
using I = DesignPattern.Iterator;

namespace DesignPattern.Iterator
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
            I::Collection collection = new I::Collection();

            collection[0] = new I::MessageModel("第1条信息", DateTime.Now);
            collection[1] = new I::MessageModel("第2条信息", DateTime.Now);
            collection[2] = new I::MessageModel("第3条信息", DateTime.Now);
            collection[3] = new I::MessageModel("第4条信息", DateTime.Now);
            collection[4] = new I::MessageModel("第5条信息", DateTime.Now);
            collection[5] = new I::MessageModel("第6条信息", DateTime.Now);
            collection[6] = new I::MessageModel("第7条信息", DateTime.Now);
            collection[7] = new I::MessageModel("第8条信息", DateTime.Now);
            collection[8] = new I::MessageModel("第9条信息", DateTime.Now);

            I::Iterator iterator = new I::Iterator(collection);

            iterator.Step = 2;

            for (I::MessageModel mm = iterator.First(); !iterator.IsDone; mm = iterator.Next())
            {
                lblMsg.AppendLine(mm.Message);
            }
        }
    }
}
