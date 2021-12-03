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
    public sealed partial class 添加权重 : ContentDialog
    {
        //(Application.Current as App)
        Duty.Weight weight = new Duty.Weight();
        public 添加权重()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            if(name.Text==""|| num.Text=="")
            {

            }
            else
            {
                weight.Level = decimal.Parse(name.Text);
                weight.Count = int.Parse(num.Text);
                (Application.Current as App).weights.Add(weight);
            }
            
            (Application.Current as App).weights.Sort((item1, item2) => { return item1.Level < item2.Level ? 1 : -1; });
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
