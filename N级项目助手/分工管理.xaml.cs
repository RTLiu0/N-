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
    public sealed partial class 分工管理 : Page
    {
        /*
         *  mem_listview.ItemsSource = (Application.Current as App).members_list;
            mem_listview.Header = "单击删改";
            if ((Application.Current as App).members_list.Count == 0)
            {
                mem_listview.Header = "试着新建一个成员";
            }
         */
        public 分工管理()
        {
            this.InitializeComponent();
            duty_p.Visibility = Visibility;
            wei_p.Visibility = Visibility.Collapsed;
            TBS.IsChecked = true;
            mem_listview.ItemsSource = (Application.Current as App).duties;
            weight_listview.ItemsSource = (Application.Current as App).weights;
            if((Application.Current as App).duties.Count==0)
            {
                mem_listview.Header = "列表为空";
            }
            if((Application.Current as App).weights.Count==0)
            {
                weight_listview.Header= "列表为空";
            }
        }
        //Visibility
        private void Button_Click(object sender, RoutedEventArgs e)//分工
        {
            duty_p.Visibility = Visibility;
            wei_p.Visibility = Visibility.Collapsed;
            TBS1.IsChecked = false;
            TBS.IsChecked = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//权重
        {
            duty_p.Visibility = Visibility.Collapsed;
            wei_p.Visibility = Visibility;
            TBS.IsChecked = false;
            TBS1.IsChecked = true;
        }

        private async  void weight_listview_ItemClick(object sender, ItemClickEventArgs e)//权重列表
        {
            修改权重 a = new 修改权重((Duty.Weight)(e.ClickedItem));
            var result = await a.ShowAsync();
            if (result.ToString() == "Primary")
            {
                //mem_listview.Header = "+";
                List<Duty.Weight> _null = new List<Duty.Weight>();
                weight_listview.ItemsSource = _null;
                weight_listview.ItemsSource = (Application.Current as App).weights;
                
            }
        }

        private async void mem_listview_ItemClick(object sender, ItemClickEventArgs e)//分工列表
        {
            修改分工 a = new 修改分工((Duty.Duty)(e.ClickedItem));
            var result = await a.ShowAsync();
            if (result.ToString() == "Primary")
            {
                //mem_listview.Header = "+";
                List<Duty.Duty> _null = new List<Duty.Duty>();
                mem_listview.ItemsSource = _null;
                mem_listview.ItemsSource = (Application.Current as App).duties;

            }
        }

        //新建的
        private async void Button_Click_2(object sender, RoutedEventArgs e)//分工
        {
            添加分工 a = new 添加分工();
            var result = await a.ShowAsync();
            if (result.ToString() == "Primary")
            {
                //mem_listview.Header = "+";
                List< Duty.Duty> _null = new List<Duty.Duty>();
                mem_listview.ItemsSource = _null;
                mem_listview.ItemsSource = (Application.Current as App).duties;
                mem_listview.Header = "点击修改";
            }
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)//权重
        {
            添加权重 a = new 添加权重();
            var result = await a.ShowAsync();
            if (result.ToString() == "Primary")
            {
                //mem_listview.Header = "+";
                List<Duty.Weight> _null = new List<Duty.Weight>();
                weight_listview.ItemsSource = _null;
                weight_listview.ItemsSource = (Application.Current as App).weights;
                weight_listview.Header = "点击修改";
            }
        }
    }
}
