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
        public int CurrentWindowHeight = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenHeight * 0.8));
        public MainWindow()
        {
            InitializeComponent();
            this.setAllWidths();
            this.setAllHeights();
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
                
                this.CurrentWindowWidth = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenWidth * 1));
                this.CurrentWindowHeight = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenHeight * 1));
                setAllWidths();
                setAllHeights();
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.CurrentWindowWidth = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenWidth * 0.8));
                this.CurrentWindowHeight = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenHeight * 0.8));
                setAllWidths();
                setAllHeights();
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
            this.column_def_2_1.Width = new GridLength(this.border_4.Width * 0.06255, GridUnitType.Star);
            this.column_def_2_2.Width = new GridLength(this.border_4.Width * 0.08510, GridUnitType.Star);
            this.column_def_2_3.Width = new GridLength(this.border_4.Width * 0.17021, GridUnitType.Star);
            this.column_def_2_4.Width = new GridLength(this.border_4.Width * 0.14894, GridUnitType.Star);
            this.column_def_2_5.Width = new GridLength(this.border_4.Width * 0.08510, GridUnitType.Star);
            this.column_def_2_6.Width = new GridLength(this.border_4.Width * 0.17021, GridUnitType.Star);
            this.column_def_2_7.Width = new GridLength(this.border_4.Width * 0.14894, GridUnitType.Star);
            
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
            this.column_def_5_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_5_2.Width = new GridLength(70, GridUnitType.Star);
            this.ckbx_IP.Width = this.panel_2.Width * 0.08;
            this.txt_bl_IP_Filter.Width = this.panel_2.Width * 0.075;
            this.column_def_6_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_6_2.Width = new GridLength(70, GridUnitType.Star);
            this.ckbx_IP.Width = this.panel_2.Width * 0.08;
            this.txt_bl_Timestamp_Filter.Width = this.panel_2.Width * 0.375;
            this.panel_SecondAnalyse.Width = this.panel_FirstAnalyse.Width;
            this.panel_ThirdAnalyse.Width = this.panel_SecondAnalyse.Width;
            this.panel_FourthAnalyse.Width = this.panel_ThirdAnalyse.Width;
            this.panel_3.Width = this.panel_2.Width;
            this.border_7.Width = this.border_6.Width;
            this.panel_4.Width = this.border_7.Width;
            this.border_8.Width = this.border_7.Width * 0.55;
            //this.btn_import.Width = this.border_8.Width;
            this.grid_1.Width = this.btn_import.Width;
            this.border_9.Width = this.border_8.Width;
            this.btn_load.Width = this.border_9.Width;
            this.column_def_5_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_5_2.Width = new GridLength(70, GridUnitType.Star);
            this.column_def_8_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_8_2.Width = new GridLength(70, GridUnitType.Star);
            this.column_def_10_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_10_2.Width = new GridLength(70, GridUnitType.Star);
            this.column_def_11_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_11_2.Width = new GridLength(70, GridUnitType.Star);
            this.column_def_12_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_12_2.Width = new GridLength(70, GridUnitType.Star);
            this.column_def_13_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_13_2.Width = new GridLength(70, GridUnitType.Star);
            this.column_def_14_1.Width = new GridLength(90.25, GridUnitType.Star);
            this.column_def_14_2.Width = new GridLength(4, GridUnitType.Star);
            this.column_def_14_3.Width = new GridLength(1.75, GridUnitType.Star);
            this.column_def_14_4.Width = new GridLength(4, GridUnitType.Star);

            this.btnExit.Width = 30;
            this.btnExit.Height = 30;
            this.icon_close.Width = 30;
            this.icon_close.Height = 30;
            this.btnExit.Margin = new Thickness(0, 10, 0, 0);
            this.icon_close.Margin = new Thickness(-17, -15, -14, -15);

            this.rctHeader.Width = 30;
            this.rctHeader.Height = 30;
            this.icon_max.Width = 30;
            this.icon_max.Height = 30;
            this.rctHeader.Margin = new Thickness(0, 10, 0, 0);
            this.icon_max.Margin = new Thickness(-17, -15, -14, -15);

            this.btnMin.Width = 30;
            this.btnMin.Height = 30;
            this.icon_min.Width = 30;
            this.icon_min.Height = 30;
            this.btnMin.Margin = new Thickness(0, 10, 0, 0);
            this.icon_min.Margin = new Thickness(-17, -15, -14, -15);

            

            //test1.Text = this.border_6.Width.ToString();

        }

        public void setAllHeights()
        {
            //Good luck!

            //450 
            this.Height = this.CurrentWindowHeight;
            this.border_1.Height = this.Height;

            this.test1.FontSize = this.Height * 0.02;

            this.row_def_1_1.Height = new GridLength(4.44, GridUnitType.Star);
            this.row_def_1_2.Height = new GridLength(95.56, GridUnitType.Star);
            this.row_def_2_1.Height = new GridLength(73, GridUnitType.Star);
            this.row_def_2_2.Height = new GridLength(this.Height * 0.0222, GridUnitType.Pixel);
            this.row_def_2_3.Height = new GridLength(21.255, GridUnitType.Star);
            //this.panel_test.Height = this.Height * 0.6222;
            //this.panel_test2.Height = this.border_3.Height = this.Height * 0.2222;
            this.border_2.Height = this.Height * 0.6222;
            this.border_3.Height = this.Height * 0.2222;

            this.panel_1.Height = this.border_3.Height;
            this.panel_5.Height = this.Height * 0.99711;
            
            this.row_def_3_1.Height = new GridLength(4.457, GridUnitType.Star);
            this.row_def_3_2.Height = new GridLength(69.979, GridUnitType.Star);
            this.row_def_3_2.Height = new GridLength(25.564, GridUnitType.Star);
            
            this.border_6.Height = this.Height * 0.6666;
            
            this.row_def_4_1.Height = new GridLength(30, GridUnitType.Star);
            this.row_def_4_2.Height = new GridLength(56.66, GridUnitType.Star);
            this.row_def_4_3.Height = new GridLength(13.33, GridUnitType.Star);
            
            this.panel_2.Height = this.Height * 0.2222;
            this.border_6.Margin = new Thickness(0, this.Height * 0.04, 0, 0);
            this.sep_1.Margin = new Thickness(0, this.Height * 0.04, 0, 0);
            this.panel_FirstAnalyse.Height = this.Height * 0.3777;
            
            this.row_def_5_1.Height = new GridLength(16.66, GridUnitType.Star);
            this.row_def_5_2.Height = new GridLength(16.66, GridUnitType.Star);
            this.row_def_5_3.Height = new GridLength(16.66, GridUnitType.Star);
            this.row_def_5_4.Height = new GridLength(16.66, GridUnitType.Star);
            this.row_def_5_5.Height = new GridLength(16.66, GridUnitType.Star);
            this.row_def_5_6.Height = new GridLength(16.66, GridUnitType.Star);

            this.datagrid_ip.Width = (this.border_2.Width - 5) / 6;
            this.datagrid_dt_event.Width = (this.border_2.Width - 5) / 6;
            this.datagrid_event.Width = (this.border_2.Width - 5) / 6;
            this.datagrid_status.Width = (this.border_2.Width - 5) / 6;
            this.datagrid_typ.Width = (this.border_2.Width - 5) / 6;
            this.datagrid_number.Width = (this.border_2.Width - 5) / 6;

            double testings = 0;
            Loaded += (s, e) =>
            {
                testings = this.column_def_5_1.ActualWidth * 0.020202;
            };

            this.ckbx_IP.MinHeight = this.panel_FirstAnalyse.Height / 100 * 0.1666;
            this.ckbx_IP.MinWidth = this.panel_FirstAnalyse.Width / 100 * 0.1666;
            this.ckbx_IP.LayoutTransform = new ScaleTransform(this.panel_FirstAnalyse.Width * 0.0060606, this.panel_FirstAnalyse.Height / 140.0);
            this.ckbx_IP.Margin = new Thickness(this.Width * 0.02, this.Height * 0.04, 0, 0);
            this.ckbx_IP.Width = this.panel_FirstAnalyse.Width * 0.04137;
            this.ckbx_IP.Height = this.panel_FirstAnalyse.Height * 0.04137;

            //TODO: Fix Checkbox-scaling-bug, occuring on lower resolutions 
            #region Fix Checkbox-scaling-bug

            this.ckbx_Timestamp.MinHeight = this.panel_FirstAnalyse.Height / 100 * 0.1666;
            this.ckbx_Timestamp.MinWidth = this.panel_FirstAnalyse.Width * 0.1666;
            this.ckbx_Timestamp.LayoutTransform = new ScaleTransform(this.panel_FirstAnalyse.Width / 165, this.panel_FirstAnalyse.Height / 140);
            this.ckbx_Timestamp.Margin = new Thickness(this.Width * 0.02, 0, 0, 0);
            this.ckbx_Timestamp.Width = this.panel_FirstAnalyse.Width * 0.05137;
            this.ckbx_Timestamp.Height = this.panel_FirstAnalyse.Height * 0.04137;

            this.ckbx_Method.MinHeight = this.panel_FirstAnalyse.Height / 100 * 0.1666;
            this.ckbx_Method.MinWidth = this.panel_FirstAnalyse.Width / 100 * 0.1666;
            this.ckbx_Method.LayoutTransform = new ScaleTransform(this.panel_FirstAnalyse.Width / 165, this.panel_FirstAnalyse.Height / 140);
            this.ckbx_Method.Margin = new Thickness(this.Width * 0.02, 0, 0, 0);
            this.ckbx_Method.Width = this.panel_FirstAnalyse.Width * 0.04137;
            this.ckbx_Method.Height = this.panel_FirstAnalyse.Height * 0.04137;

            this.ckbx_Event.MinHeight = this.panel_FirstAnalyse.Height / 100 * 0.1666;
            this.ckbx_Event.MinWidth = this.panel_FirstAnalyse.Width / 100 * 0.1666;
            this.ckbx_Event.LayoutTransform = new ScaleTransform(this.panel_FirstAnalyse.Width / 165, this.panel_FirstAnalyse.Height / 140);
            this.ckbx_Event.Margin = new Thickness(this.Width * 0.02, 0, 0, 0);
            this.ckbx_Event.Width = this.panel_FirstAnalyse.Width * 0.04137;
            this.ckbx_Event.Height = this.panel_FirstAnalyse.Height * 0.04137;

            this.ckbx_Status.MinHeight = this.panel_FirstAnalyse.Height / 100 * 0.1666;
            this.ckbx_Status.MinWidth = this.panel_FirstAnalyse.Width / 100 * 0.1666;
            this.ckbx_Status.LayoutTransform = new ScaleTransform(this.panel_FirstAnalyse.Width / 165, this.panel_FirstAnalyse.Height / 140);
            this.ckbx_Status.Margin = new Thickness(this.Width * 0.02, 0, 0, 0);
            this.ckbx_Status.Width = this.panel_FirstAnalyse.Width * 0.04137;
            this.ckbx_Status.Height = this.panel_FirstAnalyse.Height * 0.04137;

            this.ckbx_Number.MinHeight = this.panel_FirstAnalyse.Height / 100 * 0.1666;
            this.ckbx_Number.MinWidth = this.panel_FirstAnalyse.Width / 100 * 0.1666;
            this.ckbx_Number.LayoutTransform = new ScaleTransform(this.panel_FirstAnalyse.Width / 165, this.panel_FirstAnalyse.Height / 140);
            this.ckbx_Number.Margin = new Thickness(this.Width * 0.02, 0, 0, 0);
            this.ckbx_Number.Width = this.panel_FirstAnalyse.Width * 0.04137;
            this.ckbx_Number.Height = this.panel_FirstAnalyse.Height * 0.04137;

            #endregion

            this.txt_bl_IP_Filter.Height = this.panel_FirstAnalyse.Height * 0.08;
            this.txt_bl_IP_Filter.Width = this.panel_FirstAnalyse.Width * 0.7;
            this.txt_bl_IP_Filter.FontSize = this.Height * 0.025;
            this.txt_bl_IP_Filter.Margin = new Thickness(this.Width * 0.01, this.Height * 0.04, 0, 0);

            this.txt_bl_Timestamp_Filter.Height = this.panel_FirstAnalyse.Height * 0.08;
            this.txt_bl_Timestamp_Filter.Width = this.panel_FirstAnalyse.Width * 0.7;
            this.txt_bl_Timestamp_Filter.FontSize = this.Height * 0.025;
            this.txt_bl_Timestamp_Filter.Margin = new Thickness(this.Width * 0.01, 0, 0, 0);

            this.txt_bl_Method_Filter.Height = this.panel_FirstAnalyse.Height * 0.08;
            this.txt_bl_Method_Filter.Width = this.panel_FirstAnalyse.Width * 0.7;
            this.txt_bl_Method_Filter.FontSize = this.Height * 0.025;
            this.txt_bl_Method_Filter.Margin = new Thickness(this.Width * 0.01, 0, 0, 0);

            this.txt_bl_Event_Filter.Height = this.panel_FirstAnalyse.Height * 0.08;
            this.txt_bl_Event_Filter.Width = this.panel_FirstAnalyse.Width * 0.7;
            this.txt_bl_Event_Filter.FontSize = this.Height * 0.025;
            this.txt_bl_Event_Filter.Margin = new Thickness(this.Width * 0.01, 0, 0, 0);

            this.txt_bl_Status_Filter.Height = this.panel_FirstAnalyse.Height * 0.08;
            this.txt_bl_Status_Filter.Width = this.panel_FirstAnalyse.Width * 0.7;
            this.txt_bl_Status_Filter.FontSize = this.Height * 0.025;
            this.txt_bl_Status_Filter.Margin = new Thickness(this.Width * 0.01, 0, 0, 0);

            this.txt_bl_Number_Filter.Height = this.panel_FirstAnalyse.Height * 0.08;
            this.txt_bl_Number_Filter.Width = this.panel_FirstAnalyse.Width * 0.7;
            this.txt_bl_Number_Filter.FontSize = this.Height * 0.025;
            this.txt_bl_Number_Filter.Margin = new Thickness(this.Width * 0.01, 0, 0, 0);

            this.panel_3.Height = this.Height * 0.0888;
            this.border_7.Height = this.Height * 0.185;
            this.panel_4.Height = this.border_7.Height;
            this.txt_bl_Analysis.Margin = new Thickness(0, this.Height * 0.03, 0, this.Height * 0.02);
            this.txt_bl_Analysis.FontSize = this.Height * 0.04;
            this.test.FontSize = this.Height * 0.02;
            
            this.border_10.Width = this.Width * 0.125;
            this.border_10.Height = this.Height * 0.0444;
            this.border_10.Margin = new Thickness(0, this.Height * 0.02, 0, 0);
            
            this.btn_start.Width = this.Width * 0.125;
            this.btn_start.Height = this.Height * 0.0444;
            this.btn_start.FontSize = this.Height * 0.02;
            
            this.grid_2.Width = this.border_10.Width;
            this.grid_2.Height = this.border_10.Height;
            
            this.column_def_8_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_8_2.Width = new GridLength(70, GridUnitType.Star);
            this.icon_check_start.Width = this.grid_2.Width * 0.15;
            this.icon_check_start.Height = this.border_10.Height;
            this.icon_check_start.Margin = new Thickness(this.Height * 0.02, 0, 0, 0);
            
            this.txt_bl_start.Width = this.grid_2.Width * 0.70;
            this.txt_bl_start.Height = this.grid_2.Height;
            this.txt_bl_start.FontSize = this.grid_2.Width * 0.13;
            this.txt_bl_start.Margin = new Thickness(0, 0, this.Height * 0.03, 0);
            
            this.border_8.Height = this.border_10.Height;
            this.border_8.Width = this.border_10.Width;
            this.border_8.Margin = new Thickness(0, this.Height * 0.03, 0, 0);
            this.btn_import.Height = this.Height * 0.0444;
            
            this.grid_1.Width = this.border_8.Width;
            this.grid_1.Height = this.border_8.Height;
            
            this.column_def_7_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_7_2.Width = new GridLength(70, GridUnitType.Star);
            
            this.icon_import.Width = this.grid_1.Width * 0.15;
            this.icon_import.Height = this.border_8.Height;
            this.icon_import.Margin = new Thickness(0, 0, this.Height * 0.03, 0);

            this.txt_bl_import.Width = this.grid_1.Width * 0.7;
            this.txt_bl_import.Height = this.grid_1.Height;
            this.txt_bl_import.FontSize = this.grid_1.Width * 0.13;
            this.txt_bl_import.Margin = new Thickness(0, 0, this.Height * 0.06, 0);

            this.border_9.Height = this.border_10.Height;
            this.border_9.Width = this.border_10.Width;
            this.border_9.Margin = new Thickness(0, this.Height * 0.03, 0, 0);
            this.btn_load.Height = this.Height * 0.0444;

            this.grid_3.Width = this.border_9.Width;
            this.grid_3.Height = this.border_9.Height;

            this.column_def_9_1.Width = new GridLength(30, GridUnitType.Star);
            this.column_def_9_2.Width = new GridLength(70, GridUnitType.Star);

            this.icon_load.Width = this.grid_3.Width * 0.15;
            this.icon_load.Height = this.border_9.Height;
            this.icon_load.Margin = new Thickness(this.Height * 0.015, 0, 0, 0);

            this.txt_bl_load.Width = this.grid_3.Width * 0.7;
            this.txt_bl_load.Height = this.grid_3.Height;
            this.txt_bl_load.FontSize = this.grid_3.Width * 0.13;
            this.txt_bl_load.Margin = new Thickness(0, 0, this.Height * 0.03, 0);

            this.row_def_6_1.Height = new GridLength(15, GridUnitType.Star);
            this.row_def_6_2.Height = new GridLength(35, GridUnitType.Star);
            this.row_def_6_3.Height = new GridLength(15, GridUnitType.Star);
            this.row_def_6_4.Height = new GridLength(35, GridUnitType.Star);

            this.txt_bl_Zeitraum.FontSize = this.panel_1.Height * 0.08;
            this.border_4.Height = this.panel_1.Height * 0.3;
            this.txt_bl_IP.FontSize = this.panel_1.Height * 0.08;
            this.border_5.Height = this.panel_1.Height * 0.3;
            this.border_5.Margin = new Thickness(0, 45, 0, 0);

            this.icon_DateRange_1.Width = this.border_4.Width * 0.05;
            this.icon_DateRange_1.Height = this.border_4.Height * 0.7;

            this.txt_bl_von.Width = this.border_4.Width * 0.1;
            this.txt_bl_von.Height = this.border_4.Height * 0.7;
            this.txt_bl_von.FontSize = this.border_4.Height * 0.3;

            this.view_1.Height = this.border_4.Height * 0.6;
            this.datepicker_first.FontSize = this.border_4.Height * 0.15;

            this.icon_TimeRange_1.Height = this.border_4.Height * 0.6;
            this.icon_TimeRange_1.FontSize = this.border_4.Height * 0.3;
            this.icon_TimeRange_1.Width = this.border_4.Width * 0.1;

            this.txt_bl_bis.Width = this.border_4.Width * 0.1;
            this.txt_bl_bis.Height = this.border_4.Height * 0.7;
            this.txt_bl_bis.FontSize = this.border_4.Height * 0.3;

            //this.datepicker_first.LayoutTransform = new ScaleTransform(this.border_4.Height * 0.7, this.border_4.Height * 0.7);




            Loaded += (s, e) =>
            {
                FrameworkElement firstColumnRef = (FrameworkElement)FindName("FirstColumnRef");
                //this.ckbx_IP.LayoutTransform = new ScaleTransform(test_1, this.panel_FirstAnalyse.Height / 140.0);
                this.test1.Text = (this.panel_FirstAnalyse.Width * 0.0060606).ToString() + " " + testings.ToString();
            };
            


        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
