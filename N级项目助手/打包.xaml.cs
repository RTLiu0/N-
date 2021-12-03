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
using Windows.Storage;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“内容对话框”项模板

namespace N级项目助手
{
    public sealed partial class 打包 : ContentDialog
    {
        private string f = ApplicationData.Current.LocalCacheFolder.Path;
        public 打包()
        {
            this.InitializeComponent();
        }
        //(Application.Current as App)
        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            //f += @"\放入待打包文件";
            //private string f = ApplicationData.Current.LocalCacheFolder.Path;
            if(input.Text!="")
            {
                DirectoryInfo fi = new DirectoryInfo(f + @"\放入待打包文件");
                fi.MoveTo(Path.Combine(f + @"\" + input.Text));
            }
            
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            input.Text += (Application.Current as App).work.Name;
            //input.Text = t;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            input.Text += (Application.Current as App).work.Num;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            input.Text += (Application.Current as App).work.Group;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            input.Text += (Application.Current as App).work.Cla;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            input.Text += (Application.Current as App).work.Teacher;
        }
    }
}
