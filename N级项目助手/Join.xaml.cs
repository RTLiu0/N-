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
    public sealed partial class Join : ContentDialog
    {
        public Join()
        {
            this.InitializeComponent();
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            Data.Member member = new Data.Member();
            member.Name = name.Text;
            member.Num = num.Text;
            member.Type = "成员";
            (Application.Current as App).members_list.Add(member);
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
            (Application.Current as App).members_list = m.Union(m1).ToList<Data.Member>();

        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }
}
