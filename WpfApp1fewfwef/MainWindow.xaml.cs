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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;


namespace WpfApp1fewfwef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool mRestoreIfMove = false;
        public int CurrentWindowWidth = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenWidth * 0.8));
        public MainWindow()
        {
            InitializeComponent();
            this.setAllWidths();
            this.MaxHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            //Rectangle resolution = Screen.PrimaryScreen.Bounds;
            //MaxHeight = SystemParameters.VirtualScreenHeight;
            //MaxWidth = SystemParameters.VirtualScreenWidth;
            //this.Height = SystemParameters.MaximizedPrimaryScreenHeight;
            test.Items.Add("Analyse 1");
            test.Items.Add("Analyse 2");
            test.Items.Add("Analyse 3");
            test.Items.Add("Analyse 4");
            test.SelectedIndex = 0;
            keke.Items.Add("test");
            //test1.Text = this.Width.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //
            switch (test.SelectedIndex)
            {
                case 0:
                    this.CollapseAllPanels();
                    this.panel_FirstAnalyse.Visibility = Visibility.Visible;
                    break;
                case 1:
                    this.CollapseAllPanels();
                    this.panel_SecondAnalyse.Visibility = Visibility.Visible;
                    break;
                case 2:
                    this.CollapseAllPanels();
                    this.panel_ThirdAnalyse.Visibility = Visibility.Visible;
                    break;
                case 3:
                    this.CollapseAllPanels();
                    this.panel_FourthAnalyse.Visibility = Visibility.Visible;
                    break;
                default:
                    this.CollapseAllPanels();
                    this.panel_FirstAnalyse.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void CollapseAllPanels()
        {
            this.panel_FirstAnalyse.Visibility = Visibility.Collapsed;
            this.panel_SecondAnalyse.Visibility = Visibility.Collapsed;
            this.panel_ThirdAnalyse.Visibility = Visibility.Collapsed;
            this.panel_FourthAnalyse.Visibility = Visibility.Collapsed;
        }

        private void btn_Create_Login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //kek.Text = kek.Text;
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

       

        private void rctHeader_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Owner = this;
            settings.Show();
        }

        private void setAllWidths()
        {
            this.Width = this.CurrentWindowWidth;
            this.border_1.Width = this.Width;
            this.column_def_1_1.Width = new GridLength(31.25, GridUnitType.Star);
            this.column_def_1_2.Width = new GridLength(68.75, GridUnitType.Star);
            this.border_2.Width = this.Width * 0.625;
            this.border_3.Width = this.border_2.Width;
            this.panel_1.Width = this.border_3.Width;
            this.txt_bl_Zeitraum.Width = this.panel_1.Width * 0.976;
            this.border_4.Width = this.panel_1.Width * 0.94;
            this.column_def_2_1.Width = new GridLength(this.border_4.Width * 0.04255, GridUnitType.Star);
            this.column_def_2_2.Width = new GridLength(this.border_4.Width * 0.08510, GridUnitType.Star);
            this.column_def_2_3.Width = new GridLength(this.border_4.Width * 0.17021, GridUnitType.Star);
            this.column_def_2_4.Width = new GridLength(this.border_4.Width * 0.14894, GridUnitType.Star);
            this.column_def_2_5.Width = new GridLength(this.border_4.Width * 0.08510, GridUnitType.Star);
            this.column_def_2_6.Width = new GridLength(this.border_4.Width * 0.17021, GridUnitType.Star);
            this.column_def_2_7.Width = new GridLength(this.border_4.Width * 0.14894, GridUnitType.Star);
            this.column_def_2_8.Width = new GridLength(this.border_4.Width * 0.14895, GridUnitType.Star);
            this.icon_DateRange_1.Width = this.border_4.Width * 0.04255;
            this.txt_bl_bis.Width = this.border_4.Width * 0.14894;
            this.icon_TimeRange_1.Width = this.border_4.Width * 0.17021;
            this.txt_bl_von.Width = this.border_4.Width * 0.14894;
            this.icon_TimeRange_2.Width = this.border_4.Width * 0.14894;
            this.txt_bl_IP.Width = this.panel_1.Width * 0.976;
            this.border_5.Width = this.panel_1.Width * 0.94;
            this.column_def_3_1.Width = new GridLength(this.border_5.Width * 0.04255, GridUnitType.Star);
            this.column_def_3_2.Width = new GridLength(this.border_5.Width * 0.95745, GridUnitType.Star);
            this.icon_IP.Width = this.border_5.Width * 0.04255;
            this.txt_bl_IP_In.Width = this.border_5.Width * 0.95745;
            this.column_def_4_1.Width = new GridLength(16, GridUnitType.Star);
            this.column_def_4_2.Width = new GridLength(16, GridUnitType.Star);
            this.column_def_4_3.Width = new GridLength(68, GridUnitType.Star);
            this.border_6.Width = (this.border_1.Width / 100 * this.column_def_1_1.Width.Value) * 0.8;
            this.panel_2.Width = this.border_6.Width;
            this.test.Width = this.panel_2.Width * 0.9;
            this.panel_FirstAnalyse.Width = this.border_6.Width;
            this.column_def_5_1.Width = new GridLength(12, GridUnitType.Star);
            this.column_def_5_2.Width = new GridLength(88, GridUnitType.Star);
            this.ckbx_IP.Width = this.panel_2.Width * 0.08;
            this.txt_bl_IP_Filter.Width = this.panel_2.Width * 0.075;
            this.column_def_6_1.Width = new GridLength(10, GridUnitType.Star);
            this.column_def_6_2.Width = new GridLength(90, GridUnitType.Star);
            this.ckbx_IP.Width = this.panel_2.Width * 0.08;
            this.txt_bl_Timestamp_Filter.Width = this.panel_2.Width * 0.375;
            this.panel_SecondAnalyse.Width = this.panel_FirstAnalyse.Width;
            this.panel_ThirdAnalyse.Width = this.panel_SecondAnalyse.Width;
            this.panel_FourthAnalyse.Width = this.panel_ThirdAnalyse.Width;
            this.panel_3.Width = this.panel_2.Width;
            this.border_7.Width = this.border_6.Width;
            this.panel_4.Width = this.border_7.Width;
            this.border_8.Width = this.border_7.Width * 0.55;
            this.btn_import.Width = this.border_8.Width;
            this.grid_1.Width = this.btn_import.Width;
            this.column_def_7_1.Width = new GridLength(31.8181, GridUnitType.Star);
            this.column_def_7_2.Width = new GridLength(68.1819, GridUnitType.Star);
            this.border_9.Width = this.border_8.Width;
            this.btn_load.Width = this.border_9.Width;
            //test1.Text = this.border_6.Width.ToString();

        }
    }
}
