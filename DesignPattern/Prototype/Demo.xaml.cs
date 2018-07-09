using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Prototype
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
            lblMsg.AppendLine("ShallowCopy演示如下：");
            ShowShallowCopy();

            lblMsg.AppendLine("DeepCopy演示如下：");
            ShowDeepCopy();
        }

        private void ShowShallowCopy()
        {
            ShallowCopy sc = new ShallowCopy();
            sc.MessageModel = new MessageModel("ShallowCopy", DateTime.Now);

            ShallowCopy sc2 = (ShallowCopy)sc.Clone();

            lblMsg.AppendLine(sc.MessageModel.Message);
            lblMsg.AppendLine(sc2.MessageModel.Message);

            sc.MessageModel.Message = "ShallowCopyShallowCopy";

            lblMsg.AppendLine(sc.MessageModel.Message);
            lblMsg.AppendLine(sc2.MessageModel.Message);
        }

        private void ShowDeepCopy()
        {
            DeepCopy sc = new DeepCopy();
            sc.MessageModel = new MessageModel("DeepCopy", DateTime.Now);

            DeepCopy sc2 = (DeepCopy)sc.Clone();

            lblMsg.AppendLine(sc.MessageModel.Message);
            lblMsg.AppendLine(sc2.MessageModel.Message);

            sc.MessageModel.Message = "DeepCopyDeepCopy";

            lblMsg.AppendLine(sc.MessageModel.Message);
            lblMsg.AppendLine(sc2.MessageModel.Message);
        }
    }
}
