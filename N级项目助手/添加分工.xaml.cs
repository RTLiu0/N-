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
    public sealed partial class 添加分工 : ContentDialog
    {
        Duty.Duty duty = new Duty.Duty();
        public 添加分工()
        {
            this.InitializeComponent();
            
            
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if(name.Text==""||num.Text=="")
            {
                
            }
            else
            {
                //(Application.Current as App).
                duty.Name = name.Text;
                duty.Level = int.Parse(num.Text);
                duty.Count = int.Parse(count.Text);
                (Application.Current as App).duties.Add(duty);
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
