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
    public sealed partial class 修改权重 : ContentDialog
    {
        Duty.Weight t = new Duty.Weight();
        public 修改权重(Duty.Weight weight)
        {
            this.InitializeComponent();
            t = weight;
            name.Text = t.Level.ToString();
            num.Text = t.Count.ToString();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            //(Application.Current as App)
            if (del.IsChecked == true)
            {
                (Application.Current as App).weights.Remove(t);
            }
            else
            {
                int i = 0, k = 0;
                foreach (var a in (Application.Current as App).weights)
                {
                    if (a == t)
                    {
                        k = i;
                        break;
                    }
                    i++;
                }
                (Application.Current as App).weights[k].Count = int.Parse(num.Text);
                (Application.Current as App).weights[k].Level = decimal.Parse(name.Text);
            }
            (Application.Current as App).weights.Sort((item1, item2) => { return item1.Level < item2.Level ? 1 : -1; });
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
