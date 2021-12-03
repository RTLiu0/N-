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
    public sealed partial class 新建团队 : Page
    {
        Data.Work work = new Data.Work();
        
        public 新建团队()
        {
            this.InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //sel_type.SelectedValue.ToString();
            
            work.Name = team_name.Text;
            
            work.Num = team_num.Text;            
            work.Cla = team_class.Text;
            work.Teacher = team_teacher.Text;
            work.Group = team_group.Text;
            

            (Application.Current as App).work = work;
           
            this.Content = new Main(); 


        }
    }
}
