using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace N级项目助手
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class 团队 : Page
    {
        public 团队()
        {
            this.InitializeComponent();
            //(Application.Current as App).worker
        }
        private void NvAll_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            switch (args.InvokedItem)
            {
                case "成员管理": ContentFrame.Navigate(typeof(成员管理));break;
                case "分工管理": ContentFrame.Navigate(typeof(分工管理)); break;
                case "项目总览": ContentFrame.Navigate(typeof(项目总览)); break;
            }
        }
    }
}
