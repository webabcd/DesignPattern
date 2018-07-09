using System;
using Windows.UI.Xaml.Controls;

namespace DesignPattern.Common
{
    public static class MyExtensions
    {
        public static void AppendLine(this TextBlock textBlock, string message = "")
        {
            textBlock.Text += message;
            textBlock.Text += Environment.NewLine;
        }
    }
}