using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Command
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

            lblMsg.AppendLine("操作");
            lblMsg.AppendLine(m.Do(Action.Insert, new MessageModel("第1条", DateTime.Now)));
            lblMsg.AppendLine(m.Do(Action.Insert, new MessageModel("第2条", DateTime.Now)));
            lblMsg.AppendLine(m.Do(Action.Insert, new MessageModel("第3条", DateTime.Now)));
            lblMsg.AppendLine(m.Do(Action.Insert, new MessageModel("第4条", DateTime.Now)));
            lblMsg.AppendLine(m.Do(Action.Delete, new MessageModel("第2条", DateTime.Now)));
            lblMsg.AppendLine(m.Do(Action.Insert, new MessageModel("第5条", DateTime.Now)));
            lblMsg.AppendLine(m.Do(Action.Delete, new MessageModel("第3条", DateTime.Now)));
            lblMsg.AppendLine(m.Do(Action.Insert, new MessageModel("第6条", DateTime.Now)));
            lblMsg.AppendLine(m.Do(Action.Insert, new MessageModel("第7条", DateTime.Now)));
            lblMsg.AppendLine();

            lblMsg.AppendLine("撤销4次操作");
            lblMsg.AppendLine(m.Undo(4));
            lblMsg.AppendLine();

            lblMsg.AppendLine("重复2次操作");
            lblMsg.AppendLine(m.Redo(2));
            lblMsg.AppendLine();

            lblMsg.AppendLine("撤销3次操作");
            lblMsg.AppendLine(m.Undo(3));
        }
    }
}
