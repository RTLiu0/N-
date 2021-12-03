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

namespace N级项目助手
{
    public sealed partial class 修改分工 : ContentDialog
    {
        Duty.Duty t = new Duty.Duty();
        public 修改分工(Duty.Duty duty)
        {
            this.InitializeComponent();
            t = duty;
            name.Text = t.Name;
            num.Text = t.Level.ToString();
            count.Text = t.Count.ToString();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            //(Application.Current as App)
            if (del.IsChecked==true)
            {
                (Application.Current as App).duties.Remove(t);
            }
            else
            {
                int i = 0, k = 0;
                foreach(var a in (Application.Current as App).duties)
                {
                    if(a==t)
                    {
                        k = i;
                        break;
                    }
                    i++;
                }
                (Application.Current as App).duties[k].Name = name.Text;
                (Application.Current as App).duties[k].Level = int.Parse(num.Text);
                (Application.Current as App).duties[k].Count = int.Parse(count.Text);
                (Application.Current as App).duties.Sort(delegate (Duty.Duty p1, Duty.Duty p2)
                {
                    return p1.Level.CompareTo(p2.Level);//升序
                });
            }
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
