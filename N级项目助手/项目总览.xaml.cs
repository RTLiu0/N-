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
    public sealed partial class 项目总览 : Page
    {
        private string see_text = "";
        public 项目总览()
        {
            this.InitializeComponent();
            if(err_set())//存在问题
            {
                error_out.Text = see_text;
                mem_listview.Visibility = Visibility.Collapsed;
            }
            else
            {
                mix();
                mem_listview.ItemsSource = (Application.Current as App).members_list;
                error_out.Visibility = Visibility.Collapsed;
                mem_listview.Visibility = Visibility;
            }
        }
        private  bool err_set()
        {

            //输出的错误
            
            bool err=false;
            //存在组员和组长
            bool have_hander=false;
            int count = (Application.Current as App).members_list.Count;
            if(count>0)
            {
                foreach(var a in (Application.Current as App).members_list)
                {
                    if(a.Type=="组长")
                    {
                        have_hander = true;
                    }
                }
            }
            else
            {
                see_text += "设置组员\n";
                err = true;
            }
            if(have_hander==false)
            {
                see_text += "设置一个组长\n";
                err = true;
            }
            //分工等于成员数
            int work = 0;
            foreach(var a in (Application.Current as App).duties)
            {
                work += a.Count;
            }
            if(work<2)
            {
                err = true;
                see_text += "分工数量应该等于成员数\n";
            }
            //至少存在2个权重数
            int wei = 0;
            foreach(var a in (Application.Current as App).weights)
            {
                wei += a.Count;
            }
            if(wei<2)
            {
                err = true;
                see_text += "至少存在2个权重数\n";
            }
            //输出错误
            
            
            if (err)
            {
                return true;
                
            }
            return false;
        }
       
        private void mix()//组长最高
        {
            int p = 0;
            decimal c = 0;
            foreach(var a in (Application.Current as App).weights)
            {
                int e = a.Count;
                c = a.Level;
                while(e>0)
                {
                    (Application.Current as App).members_list[p].Weight = a.Level;
                    p++;
                    e--;
                }
            }
            
            if(p< (Application.Current as App).members_list.Count)
            {
                //p--;
                while(p< (Application.Current as App).members_list.Count)
                {
                    (Application.Current as App).members_list[p].Weight = c;//err
                    p++;
                }
            }
            
                p = 0;
            foreach (var a in (Application.Current as App).duties)
            {
                int e = a.Count;
                while (e > 0)
                {
                    (Application.Current as App).members_list[p].Todo = a.Name;
                    p++;
                    e--;
                }
            }
        }
        
        

        
    }
}
