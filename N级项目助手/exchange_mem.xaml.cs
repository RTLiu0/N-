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

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“内容对话框”项模板
/// <summary>
/// (Application.Current as App).members_list;
/// </summary>
namespace N级项目助手
{
    public sealed partial class exchange_mem : ContentDialog
    {
        private Data.Member mem = new Data.Member();//待处理的元素
        
        public exchange_mem(Data.Member origan)
        {
            this.InitializeComponent();
            mem = origan;
            name.Text = origan.Name;
            num.Text = origan.Num;
            if(origan.Type=="组长")
            {
                hander.IsChecked = true;
                
            }
            
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if(del.IsChecked==true)//删除
            {
                (Application.Current as App).members_list.Remove(mem);
               
            }
            else//更改
            {


               // int i = (Application.Current as App).members_list.IndexOf(mem);
               // /*
                int i=0;
                int k=0;
                foreach(var a in (Application.Current as App).members_list)
                {                    
                    if((Application.Current as App).members_list[k]==mem)
                    {
                        i = k;
                        break;
                    }
                    k++;
                }
               // */
                (Application.Current as App).members_list[i].Name = name.Text;
                (Application.Current as App).members_list[i].Num = num.Text;
                //(Application.Current as App).members_list[i].Num = i.ToString();
                if (hander.IsChecked==true)
                {
                    (Application.Current as App).members_list[i].Type = "组长";
                }
                else
                {
                    (Application.Current as App).members_list[i].Type = "组员";
                }
                
                List<Data.Member> m = new List<Data.Member>();
                List<Data.Member> m1 = new List<Data.Member>();
                foreach (var a in (Application.Current as App).members_list)
                {
                    if (a.Type == "组长")
                    {
                        m.Add(a);
                    }
                    else
                    {
                        m1.Add(a);
                    }
                }
                (Application.Current as App).members_list.Clear();
                (Application.Current as App).members_list= m.Union(m1).ToList<Data.Member>();

            }
            
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
