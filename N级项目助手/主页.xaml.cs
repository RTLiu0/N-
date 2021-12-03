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
    public sealed partial class 主页 : Page
    {
        public 主页()
        {
            this.InitializeComponent();
            team_name.Text= (Application.Current as App).work.Name;
            team_num.Text= (Application.Current as App).work.Num;
            team_class.Text= (Application.Current as App).work.Cla;
            team_group.Text = (Application.Current as App).work.Group;
            team_teacher.Text= (Application.Current as App).work.Teacher;            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current as App).work.Name = team_name.Text;
            (Application.Current as App).work.Num = team_num.Text;
            (Application.Current as App).work.Cla = team_class.Text;
            (Application.Current as App).work.Teacher = team_teacher.Text;
            (Application.Current as App).work.Group = team_group.Text;
        }
    }
}
