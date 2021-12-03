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
    public sealed partial class 成员管理 : Page
    {
        private List<Data.Member> _null = new List<Data.Member>();
        public 成员管理()
        {
            this.InitializeComponent();
            
            mem_listview.ItemsSource = (Application.Current as App).members_list;
            mem_listview.Header = "单击删改";
            if ((Application.Current as App).members_list.Count == 0)
            {
                mem_listview.Header = "试着新建一个成员";
            }

        }

        private async void Button_Click(object sender, RoutedEventArgs e)//添加一个成员
        {
            Join join = new Join();
            
            var result = await join.ShowAsync();
            if(result.ToString()== "Primary")
            {
                //mem_listview.Header = "+";
                mem_listview.ItemsSource = _null;
                mem_listview.ItemsSource = (Application.Current as App).members_list;
                found_master();
            }
        }


        private async void mem_listview_ItemClick(object sender, ItemClickEventArgs e)
        {
            exchange_mem ex = new exchange_mem((Data.Member)(e.ClickedItem));
            var result = await ex.ShowAsync();
            if (result.ToString() == "Primary")
            {
                //mem_listview.Header = "+";
                mem_listview.ItemsSource = _null;
                mem_listview.ItemsSource = (Application.Current as App).members_list;
                found_master();
            }
        }
        private void found_master()
        {
            bool i = false;
                foreach(var a in (Application.Current as App).members_list)
                {
                    if(a.Type=="组长")
                    {
                        i = true;
                    }
                }
                if(i)
                {
                    mem_listview.Header = "单击删改";
                }
                else
                {
                    mem_listview.Header = "单击删改"+"请设置至少一个组长";
                }
        }
    }
}
