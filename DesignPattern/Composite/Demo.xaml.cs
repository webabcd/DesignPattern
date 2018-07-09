using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;

namespace DesignPattern.Composite
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
            MessageModelComposite root = new MessageModelComposite("树枝A");
            root.Add(new MessageModelLeaf("树叶A", new MessageModel("Message内容A", DateTime.Now)));
            root.Add(new MessageModelLeaf("树叶B", new MessageModel("Message内容B", DateTime.Now)));

            MessageModelComposite comp = new MessageModelComposite("树枝B");
            comp.Add(new MessageModelLeaf("树叶C", new MessageModel("Message内容C", DateTime.Now)));
            comp.Add(new MessageModelLeaf("树叶D", new MessageModel("Message内容D", DateTime.Now)));

            root.Add(comp);
            root.Add(new MessageModelLeaf("树叶E", new MessageModel("Message内容E", DateTime.Now)));

            MessageModelLeaf l = new MessageModelLeaf("树叶F", new MessageModel("Message内容F", DateTime.Now));
            root.Add(l);
            root.Remove(l);

            lblMsg.AppendLine(root.GetData(1));
        }
    }
}
