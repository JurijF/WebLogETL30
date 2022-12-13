using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1fewfwef
{
    /// <summary>
    /// Interaction logic for Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        public int CurrentWindowWidth = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenWidth * 0.8));
        public int CurrentWindowHeight = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenHeight * 0.8));
        Scaling scaling = new Scaling();

        public Information()
        {
            InitializeComponent();
            scaling.information = this;
            scaling.SetInformationSizes();
        }

        private void information_btn_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.IsEnabled = true;
            this.Owner.Activate();
        }
         
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton.ToString() == "Left")
            {
                DragMove();
            }
        }

        private void information_btn_firstanalysis_Click(object sender, RoutedEventArgs e)
        {
            this.information_txt_bl_first.Visibility = Visibility.Visible;
            this.information_txt_bl_second.Visibility = Visibility.Collapsed;
            this.information_txt_bl_third.Visibility = Visibility.Collapsed;
            this.information_txt_bl_fourth.Visibility = Visibility.Collapsed;
            this.information_grid_2.Visibility = Visibility.Collapsed;
        }

        private void information_btn_secondanalysis_Click(object sender, RoutedEventArgs e)
        {
            this.information_txt_bl_first.Visibility = Visibility.Collapsed;
            this.information_txt_bl_second.Visibility = Visibility.Visible;
            this.information_txt_bl_third.Visibility = Visibility.Collapsed;
            this.information_txt_bl_fourth.Visibility = Visibility.Collapsed;
            this.information_grid_2.Visibility = Visibility.Collapsed;
        }

        private void information_btn_thirdanalysis_Click(object sender, RoutedEventArgs e)
        {
            this.information_txt_bl_first.Visibility = Visibility.Collapsed;
            this.information_txt_bl_second.Visibility = Visibility.Collapsed;
            this.information_txt_bl_third.Visibility = Visibility.Visible;
            this.information_txt_bl_fourth.Visibility = Visibility.Collapsed;
            this.information_grid_2.Visibility = Visibility.Collapsed;
        }

        private void information_btn_fourthanalysis_Click(object sender, RoutedEventArgs e)
        {
            this.information_txt_bl_first.Visibility = Visibility.Collapsed;
            this.information_txt_bl_second.Visibility = Visibility.Collapsed;
            this.information_txt_bl_third.Visibility = Visibility.Collapsed;
            this.information_txt_bl_fourth.Visibility = Visibility.Visible;
            this.information_grid_2.Visibility = Visibility.Collapsed;
        }

        private void information_btn_info_Click(object sender, RoutedEventArgs e)
        {
            this.information_txt_bl_first.Visibility = Visibility.Collapsed;
            this.information_txt_bl_second.Visibility = Visibility.Collapsed;
            this.information_txt_bl_third.Visibility = Visibility.Collapsed;
            this.information_txt_bl_fourth.Visibility = Visibility.Collapsed;
            this.information_grid_2.Visibility = Visibility.Visible;
        }
    }
}