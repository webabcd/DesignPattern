using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using DesignPattern.Common;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
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
            // 使用单例模式，保证一个类仅有一个实例
            lblMsg.AppendLine(Singleton<Test>.Instance.Time);
            await Task.Delay(1000);
            lblMsg.AppendLine(Singleton<Test>.Instance.Time);

            // 不用单例模式
            Test t = new Test();
            lblMsg.AppendLine(t.Time);
            await Task.Delay(1000);
            Test t2 = new Test();
            lblMsg.AppendLine(t2.Time);
        }
    }

    public class Test
    {
        private DateTime _time;

        public Test()
        {
            _time = DateTime.Now;
        }

        public string Time
        {
            get { return _time.ToString(); }
        }
    }
}
