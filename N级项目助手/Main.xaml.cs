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
    public sealed partial class Main : Page
    {
        public Main()
        {
            this.InitializeComponent();
        }
        private void NvAll_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            
            if (args.IsSettingsInvoked)
            {
                hambuger.Header = "设置";
                ContentFrame.Navigate(typeof(setting));
            }
            else
            {
                switch (args.InvokedItem)
                {
                    case "主页": ContentFrame.Navigate(typeof(主页));  hambuger.Header = "主页"; break;
                    case "团队": ContentFrame.Navigate(typeof(团队)); hambuger.Header = "团队"; break;
                    case "项目打包": ContentFrame.Navigate(typeof(项目打包)); hambuger.Header = "打包"; break;
                }
            }
        }
    }
}
