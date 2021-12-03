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
using Microsoft.Win32;
using Windows.Storage;
using Windows.UI.Popups;
using Windows.Storage.Pickers;
using Windows.Storage.AccessCache;


// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace N级项目助手
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class 项目打包 : Page
    {
        List<Data.File.File> files = new List<Data.File.File>();
        List<Data.File.File> _NULL = new List<Data.File.File>();
        private string f = ApplicationData.Current.LocalCacheFolder.Path;
        private string f1 = ApplicationData.Current.LocalCacheFolder.Path;
        public 项目打包()
        {
            this.InitializeComponent();
            DirectoryInfo info = new DirectoryInfo(f);
            sug.Text = f;
            info.CreateSubdirectory("放入待打包文件");
            f += @"\放入待打包文件";
            bag.Visibility = Visibility.Collapsed;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            renew();
        }
        private void renew()
        {
            files.Clear();
            Data.File.File i = new Data.File.File();
            DirectoryInfo info = new DirectoryInfo(f);
            IEnumerable<FileInfo> dir = info.EnumerateFiles();
            foreach (var a in dir)
            {
                i.Name = a.Name;
                i.Rode = a.FullName;
                files.Add(i);
            }
            file_listview.ItemsSource = _NULL;
            file_listview.ItemsSource = files;
            if (files.Count == 0)
            {
                file_listview.Header = "空";
                bag.Visibility = Visibility.Collapsed;
            }
            else
            {
                bag.Visibility = Visibility;
                file_listview.Header = "文件：";
            }
        }

        private void weight_listview_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //FileStream zipFileToOpen = new FileStream(f1, FileMode.Create);
            //Join join = new Join();
            打包 a = new 打包();
            var result = await a.ShowAsync();
            
                if (result.ToString() == "Primary")
                {
                    DirectoryInfo info = new DirectoryInfo(ApplicationData.Current.LocalCacheFolder.Path);
                    info.CreateSubdirectory("放入待打包文件");
                    
                }
            bag.Visibility = Visibility.Collapsed;
           f = ApplicationData.Current.LocalCacheFolder.Path;
            renew();
        }
    }
}
