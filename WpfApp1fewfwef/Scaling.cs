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
    internal class Scaling
    {
        public MainWindow? main;
        public Settings? settings;
        public Import? import;
        public Information? information;

        #pragma warning disable CS8602
        public void SetSizes()
        {
            //Good Luck!

            main.Width = main.CurrentWindowWidth;
            main.border_1.Width = main.Width;

            main.column_def_1_1.Width = new GridLength(31.25, GridUnitType.Star);
            main.column_def_1_2.Width = new GridLength(68.75, GridUnitType.Star);

            main.border_2.Width = main.Width * 0.625;
            main.border_3.Width = main.border_2.Width;
            main.panel_1.Width = main.border_3.Width;

            main.txt_bl_Zeitraum.Width = main.panel_1.Width * 0.976;

            main.border_4.Width = main.panel_1.Width * 0.7;
            main.border_4.Margin = new Thickness(main.panel_1.Width * 0.03, 0, 0, 0);

            main.column_def_2_1.Width = new GridLength(5, GridUnitType.Star);
            main.column_def_2_2.Width = new GridLength(5, GridUnitType.Star);
            main.column_def_2_3.Width = new GridLength(10, GridUnitType.Star);
            main.column_def_2_4.Width = new GridLength(10, GridUnitType.Star);
            main.column_def_2_5.Width = new GridLength(5, GridUnitType.Star);
            main.column_def_2_6.Width = new GridLength(10, GridUnitType.Star);
            main.column_def_2_7.Width = new GridLength(10, GridUnitType.Star);

            main.icon_DateRange_1.Width = main.border_4.Width * 0.04255;
            main.txt_bl_bis.Width = main.border_4.Width * 0.14894;
            main.dTPicker_main_TimeUntil.Width = main.border_4.Width * 0.17021;
            main.txt_bl_von.Width = main.border_4.Width * 0.14894;
            main.dTPicker_main_TimeFrom.Width = main.border_4.Width * 0.14894;
            main.txt_bl_IP.Width = main.panel_1.Width * 0.976;

            main.border_5.Width = main.panel_1.Width * 0.94;

            main.column_def_3_1.Width = new GridLength(6.5, GridUnitType.Star);
            main.column_def_3_2.Width = new GridLength(93.5, GridUnitType.Star);

            main.column_def_4_1.Width = new GridLength(16, GridUnitType.Star);
            main.column_def_4_2.Width = new GridLength(16, GridUnitType.Star);
            main.column_def_4_3.Width = new GridLength(68, GridUnitType.Star);

            main.border_6.Width = (main.border_1.Width / 100 * main.column_def_1_1.Width.Value) * 0.8;
            main.panel_2.Width = main.border_6.Width;
            main.test.Width = main.panel_2.Width * 0.9;
            main.combo_Analysis.Width = main.panel_2.Width * 0.7;
            main.panel_FirstAnalyse.Width = main.border_6.Width;

            main.column_def_5_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_5_2.Width = new GridLength(70, GridUnitType.Star);

            main.ckbx_IP.Width = main.panel_2.Width * 0.08;
            main.txt_bl_IP_Filter.Width = main.panel_2.Width * 0.075;

            main.column_def_6_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_6_2.Width = new GridLength(70, GridUnitType.Star);

            main.ckbx_IP.Width = main.panel_2.Width * 0.08;
            main.txt_bl_Timestamp_Filter.Width = main.panel_2.Width * 0.375;

            main.panel_SecondAnalyse.Width = main.panel_FirstAnalyse.Width;
            main.panel_ThirdAnalyse.Width = main.panel_SecondAnalyse.Width;
            main.panel_FourthAnalyse.Width = main.panel_ThirdAnalyse.Width;
            main.panel_3.Width = main.panel_2.Width;

            main.border_7.Width = main.border_6.Width;

            main.panel_4.Width = main.border_7.Width;

            main.border_8.Width = main.border_7.Width * 0.55;

            main.grid_1.Width = main.btn_import.Width;
            main.border_9.Width = main.border_8.Width;
            main.btn_load.Width = main.border_9.Width;

            main.column_def_5_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_5_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_8_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_8_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_10_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_10_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_11_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_11_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_12_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_12_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_13_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_13_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_14_1.Width = new GridLength(90.25, GridUnitType.Star);
            main.column_def_14_2.Width = new GridLength(4, GridUnitType.Star);
            main.column_def_14_3.Width = new GridLength(1.75, GridUnitType.Star);
            main.column_def_14_4.Width = new GridLength(4, GridUnitType.Star);

            main.column_def_15_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_15_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_16_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_16_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_17_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_17_2.Width = new GridLength(70, GridUnitType.Star);

            main.column_def_18_1.Width = new GridLength(20, GridUnitType.Star);
            main.column_def_18_2.Width = new GridLength(80, GridUnitType.Star);

            //TODO: SCALE THIS SHIT I FORGOT
            #region this shit
            main.btnExit.Width = 30;
            main.btnExit.Height = 30;

            main.icon_close.Width = 30;
            main.icon_close.Height = 30;

            main.btnExit.Margin = new Thickness(0, 10, 0, 0);
            main.icon_close.Margin = new Thickness(-17, -15, -14, -15);

            main.rctHeader.Width = 30;
            main.rctHeader.Height = 30;

            main.icon_max.Width = 30;
            main.icon_max.Height = 30;

            main.rctHeader.Margin = new Thickness(0, 10, 0, 0);
            main.icon_max.Margin = new Thickness(-17, -15, -14, -15);

            main.btnMin.Width = 30;
            main.btnMin.Height = 30;
            main.icon_min.Width = 30;
            main.icon_min.Height = 30;
            main.btnMin.Margin = new Thickness(0, 10, 0, 0);
            main.icon_min.Margin = new Thickness(-17, -15, -14, -15);
            #endregion

            main.Height = main.CurrentWindowHeight;
            main.border_1.Height = main.Height;

            main.test.Height = main.Height * 0.05;
            main.test1.FontSize = main.Height * 0.02;

            main.row_def_1_1.Height = new GridLength(4.44, GridUnitType.Star);
            main.row_def_1_2.Height = new GridLength(95.56, GridUnitType.Star);

            main.row_def_2_1.Height = new GridLength(73, GridUnitType.Star);
            main.row_def_2_2.Height = new GridLength(main.Height * 0.0222, GridUnitType.Pixel);
            main.row_def_2_3.Height = new GridLength(21.255, GridUnitType.Star);

            main.border_2.Height = main.Height * 0.6222;
            main.border_3.Height = main.Height * 0.2222;

            main.panel_1.Height = main.border_3.Height;
            main.panel_5.Height = main.Height * 0.99711;

            main.row_def_3_1.Height = new GridLength(10, GridUnitType.Star);
            main.row_def_3_2.Height = new GridLength(68, GridUnitType.Star);
            main.row_def_3_2.Height = new GridLength(22, GridUnitType.Star);

            main.border_6.Height = main.Height * 0.6666;

            main.row_def_4_1.Height = new GridLength(30, GridUnitType.Star);
            main.row_def_4_2.Height = new GridLength(56.66, GridUnitType.Star);
            main.row_def_4_3.Height = new GridLength(13.33, GridUnitType.Star);

            main.panel_2.Height = main.Height * 0.2222;
            main.border_6.Margin = new Thickness(0, main.Height * 0.04, 0, 0);
            main.sep_1.Margin = new Thickness(0, main.Height * 0.04, 0, 0);

            main.panel_FirstAnalyse.Height = main.Height * 0.3777;
            main.panel_SecondAnalyse.Height = main.Height * 0.3777;
            main.panel_ThirdAnalyse.Height = main.Height * 0.3777;
            main.panel_FourthAnalyse.Height = main.Height * 0.3777;

            main.grid_6.Height = main.panel_FirstAnalyse.Height * 0.95;

            main.row_def_5_1.Height = new GridLength(16.66, GridUnitType.Star);
            main.row_def_5_2.Height = new GridLength(16.66, GridUnitType.Star);
            main.row_def_5_3.Height = new GridLength(16.66, GridUnitType.Star);
            main.row_def_5_4.Height = new GridLength(16.66, GridUnitType.Star);
            main.row_def_5_5.Height = new GridLength(16.66, GridUnitType.Star);
            main.row_def_5_6.Height = new GridLength(16.66, GridUnitType.Star);

            main.grid_4.Height = main.panel_ThirdAnalyse.Height * 0.9;

            main.row_def_7_1.Height = new GridLength(33, GridUnitType.Star);
            main.row_def_7_2.Height = new GridLength(33, GridUnitType.Star);
            main.row_def_7_3.Height = new GridLength(33, GridUnitType.Star);

            main.grid_5.Height = main.panel_FourthAnalyse.Height * 0.9;

            main.row_def_8_1.Height = new GridLength(15, GridUnitType.Star);
            main.row_def_8_2.Height = new GridLength(15, GridUnitType.Star);
            main.row_def_8_3.Height = new GridLength(5, GridUnitType.Star);
            main.row_def_8_4.Height = new GridLength(65, GridUnitType.Star);

            main.datagrid_ip.Width = (main.border_2.Width - 5) / 6;
            main.datagrid_dt_event.Width = (main.border_2.Width - 5) / 6;
            main.datagrid_event.Width = (main.border_2.Width - 5) / 6;
            main.datagrid_status.Width = (main.border_2.Width - 5) / 6;
            main.datagrid_typ.Width = (main.border_2.Width - 5) / 6;
            main.datagrid_number.Width = (main.border_2.Width - 5) / 6;

            main.ckbx_IP.MinHeight = main.panel_FirstAnalyse.Height / 100 * 0.1666;
            main.ckbx_IP.MinWidth = main.panel_FirstAnalyse.Width / 100 * 0.1666;
            main.ckbx_IP.LayoutTransform = new ScaleTransform(main.panel_FirstAnalyse.Width * 0.0060606, main.panel_FirstAnalyse.Height / 140);
            main.ckbx_IP.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_IP.Width = main.panel_FirstAnalyse.Width * 0.04137;
            main.ckbx_IP.Height = main.panel_FirstAnalyse.Height * 0.04137;

            //TODO: Fix Checkbox-scaling-bug, occuring on lower resolutions 
            #region Fix Checkbox-scaling-bug

            main.ckbx_Timestamp.MinHeight = main.panel_FirstAnalyse.Height / 100 * 0.1666;
            main.ckbx_Timestamp.MinWidth = main.panel_FirstAnalyse.Width * 0.1666;
            main.ckbx_Timestamp.LayoutTransform = new ScaleTransform(main.panel_FirstAnalyse.Width / 165, main.panel_FirstAnalyse.Height / 140);
            main.ckbx_Timestamp.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_Timestamp.Width = main.panel_FirstAnalyse.Width * 0.05137;
            main.ckbx_Timestamp.Height = main.panel_FirstAnalyse.Height * 0.04137;

            main.ckbx_Method.MinHeight = main.panel_FirstAnalyse.Height / 100 * 0.1666;
            main.ckbx_Method.MinWidth = main.panel_FirstAnalyse.Width / 100 * 0.1666;
            main.ckbx_Method.LayoutTransform = new ScaleTransform(main.panel_FirstAnalyse.Width / 165, main.panel_FirstAnalyse.Height / 140);
            main.ckbx_Method.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_Method.Width = main.panel_FirstAnalyse.Width * 0.04137;
            main.ckbx_Method.Height = main.panel_FirstAnalyse.Height * 0.04137;

            main.ckbx_Event.MinHeight = main.panel_FirstAnalyse.Height / 100 * 0.1666;
            main.ckbx_Event.MinWidth = main.panel_FirstAnalyse.Width / 100 * 0.1666;
            main.ckbx_Event.LayoutTransform = new ScaleTransform(main.panel_FirstAnalyse.Width / 165, main.panel_FirstAnalyse.Height / 140);
            main.ckbx_Event.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_Event.Width = main.panel_FirstAnalyse.Width * 0.04137;
            main.ckbx_Event.Height = main.panel_FirstAnalyse.Height * 0.04137;

            main.ckbx_Status.MinHeight = main.panel_FirstAnalyse.Height / 100 * 0.1666;
            main.ckbx_Status.MinWidth = main.panel_FirstAnalyse.Width / 100 * 0.1666;
            main.ckbx_Status.LayoutTransform = new ScaleTransform(main.panel_FirstAnalyse.Width / 165, main.panel_FirstAnalyse.Height / 140);
            main.ckbx_Status.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_Status.Width = main.panel_FirstAnalyse.Width * 0.04137;
            main.ckbx_Status.Height = main.panel_FirstAnalyse.Height * 0.04137;

            main.ckbx_Number.MinHeight = main.panel_FirstAnalyse.Height / 100 * 0.1666;
            main.ckbx_Number.MinWidth = main.panel_FirstAnalyse.Width / 100 * 0.1666;
            main.ckbx_Number.LayoutTransform = new ScaleTransform(main.panel_FirstAnalyse.Width / 165, main.panel_FirstAnalyse.Height / 140);
            main.ckbx_Number.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_Number.Width = main.panel_FirstAnalyse.Width * 0.04137;
            main.ckbx_Number.Height = main.panel_FirstAnalyse.Height * 0.04137;

            #endregion

            main.txt_bl_IP_Filter.Height = main.panel_FirstAnalyse.Height * 0.08;
            main.txt_bl_IP_Filter.Width = main.panel_FirstAnalyse.Width * 0.7;
            main.txt_bl_IP_Filter.FontSize = main.Height * 0.025;
            main.txt_bl_IP_Filter.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.txt_bl_Timestamp_Filter.Height = main.panel_FirstAnalyse.Height * 0.08;
            main.txt_bl_Timestamp_Filter.Width = main.panel_FirstAnalyse.Width * 0.7;
            main.txt_bl_Timestamp_Filter.FontSize = main.Height * 0.025;
            main.txt_bl_Timestamp_Filter.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.txt_bl_Method_Filter.Height = main.panel_FirstAnalyse.Height * 0.08;
            main.txt_bl_Method_Filter.Width = main.panel_FirstAnalyse.Width * 0.7;
            main.txt_bl_Method_Filter.FontSize = main.Height * 0.025;
            main.txt_bl_Method_Filter.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.txt_bl_Event_Filter.Height = main.panel_FirstAnalyse.Height * 0.08;
            main.txt_bl_Event_Filter.Width = main.panel_FirstAnalyse.Width * 0.7;
            main.txt_bl_Event_Filter.FontSize = main.Height * 0.025;
            main.txt_bl_Event_Filter.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.txt_bl_Status_Filter.Height = main.panel_FirstAnalyse.Height * 0.08;
            main.txt_bl_Status_Filter.Width = main.panel_FirstAnalyse.Width * 0.7;
            main.txt_bl_Status_Filter.FontSize = main.Height * 0.025;
            main.txt_bl_Status_Filter.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.txt_bl_Number_Filter.Height = main.panel_FirstAnalyse.Height * 0.08;
            main.txt_bl_Number_Filter.Width = main.panel_FirstAnalyse.Width * 0.7;
            main.txt_bl_Number_Filter.FontSize = main.Height * 0.025;
            main.txt_bl_Number_Filter.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.panel_3.Height = main.Height * 0.0888;
            main.border_7.Height = main.Height * 0.185;
            main.panel_4.Height = main.border_7.Height;
            main.txt_bl_Analysis.Margin = new Thickness(0, main.Height * 0.03, 0, main.Height * 0.02);
            main.txt_bl_Analysis.FontSize = main.Height * 0.04;
            main.test.FontSize = main.Height * 0.02;

            main.border_10.Width = main.Width * 0.125;
            main.border_10.Height = main.Height * 0.0444;
            main.border_10.Margin = new Thickness(0, main.Height * 0.02, 0, 0);

            main.btn_start.Width = main.Width * 0.125;
            main.btn_start.Height = main.Height * 0.0444;
            main.btn_start.FontSize = main.Height * 0.02;

            main.grid_2.Width = main.border_10.Width;
            main.grid_2.Height = main.border_10.Height;

            main.column_def_8_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_8_2.Width = new GridLength(70, GridUnitType.Star);
            main.icon_check_start.Width = main.grid_2.Width * 0.15;
            main.icon_check_start.Height = main.border_10.Height;
            main.icon_check_start.Margin = new Thickness(main.Height * 0.02, 0, 0, 0);

            main.txt_bl_start.Width = main.grid_2.Width * 0.70;
            main.txt_bl_start.Height = main.grid_2.Height;
            main.txt_bl_start.FontSize = main.grid_2.Width * 0.13;
            main.txt_bl_start.Margin = new Thickness(0, 0, main.Height * 0.03, 0);

            main.border_8.Height = main.border_10.Height;
            main.border_8.Width = main.border_10.Width;
            main.border_8.Margin = new Thickness(0, main.Height * 0.03, 0, 0);
            main.btn_import.Height = main.Height * 0.0444;

            main.grid_1.Width = main.border_8.Width;
            main.grid_1.Height = main.border_8.Height;

            main.column_def_7_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_7_2.Width = new GridLength(70, GridUnitType.Star);

            main.icon_import.Width = main.grid_1.Width * 0.15;
            main.icon_import.Height = main.border_8.Height;
            main.icon_import.Margin = new Thickness(0, 0, main.Height * 0.03, 0);

            main.txt_bl_import.Width = main.grid_1.Width * 0.7;
            main.txt_bl_import.Height = main.grid_1.Height;
            main.txt_bl_import.FontSize = main.grid_1.Width * 0.13;
            main.txt_bl_import.Margin = new Thickness(0, 0, main.Height * 0.06, 0);

            main.border_9.Height = main.border_10.Height;
            main.border_9.Width = main.border_10.Width;
            main.border_9.Margin = new Thickness(0, main.Height * 0.03, 0, 0);
            main.btn_load.Height = main.Height * 0.0444;

            main.grid_3.Width = main.border_9.Width;
            main.grid_3.Height = main.border_9.Height;

            main.column_def_9_1.Width = new GridLength(30, GridUnitType.Star);
            main.column_def_9_2.Width = new GridLength(70, GridUnitType.Star);

            main.icon_load.Width = main.grid_3.Width * 0.15;
            main.icon_load.Height = main.border_9.Height;
            main.icon_load.Margin = new Thickness(main.Height * 0.015, 0, 0, 0);

            main.txt_bl_load.Width = main.grid_3.Width * 0.7;
            main.txt_bl_load.Height = main.grid_3.Height;
            main.txt_bl_load.FontSize = main.grid_3.Width * 0.13;
            main.txt_bl_load.Margin = new Thickness(0, 0, main.Height * 0.03, 0);

            main.row_def_6_1.Height = new GridLength(15, GridUnitType.Star);
            main.row_def_6_2.Height = new GridLength(35, GridUnitType.Star);
            main.row_def_6_3.Height = new GridLength(15, GridUnitType.Star);
            main.row_def_6_4.Height = new GridLength(35, GridUnitType.Star);

            main.txt_bl_Zeitraum.Margin = new Thickness(main.panel_1.Width * 0.03, main.panel_1.Height * 0.03, 0, 0);
            main.txt_bl_Zeitraum.FontSize = main.panel_1.Height * 0.08;
            main.border_4.Height = main.panel_1.Height * 0.3;
            main.txt_bl_IP.Margin = new Thickness(main.panel_1.Width * 0.03, main.panel_1.Height * 0.03, 0, 0);
            main.txt_bl_IP.FontSize = main.panel_1.Height * 0.08;
            main.border_5.Height = main.panel_1.Height * 0.3;
            main.border_5.Margin = new Thickness(0, main.panel_1.Height * 0.16, 0, 0);

            main.icon_DateRange_1.Width = main.border_4.Width * 0.1;
            main.icon_DateRange_1.Height = main.border_4.Height * 0.7;

            main.icon_IP.Width = main.border_4.Width * 0.1;
            main.icon_IP.Height = main.border_4.Height * 0.7;

            main.txt_bl_IP_In.Width = main.border_5.Width * 0.90;
            main.txt_bl_IP_In.Height = main.border_5.Height * 0.6;
            main.txt_bl_IP_In.FontSize = main.border_5.Height * 0.3;

            main.txt_bl_von.Width = main.border_4.Width * 0.07;
            main.txt_bl_von.Height = main.border_4.Height * 0.55;
            main.txt_bl_von.FontSize = main.border_4.Height * 0.3;
            main.txt_bl_von.Margin = new Thickness(main.border_4.Width * 0.004, 0, 0, 0);

            main.view_1.Height = main.border_4.Height * 0.6;
            main.dTPicker_main_DateUntil.FontSize = main.border_4.Height * 0.15;

            main.dTPicker_main_TimeUntil.Height = main.border_4.Height * 0.585;
            main.dTPicker_main_TimeUntil.FontSize = main.border_4.Height * 0.3;
            main.dTPicker_main_TimeUntil.Width = main.border_4.Width * 0.15;

            main.txt_bl_bis.Width = main.border_4.Width * 0.07;
            main.txt_bl_bis.Height = main.border_4.Height * 0.55;
            main.txt_bl_bis.FontSize = main.border_4.Height * 0.3;
            main.txt_bl_bis.Margin = new Thickness(main.border_4.Width * 0.004, 0, 0, 0);

            main.view_2.Height = main.border_4.Height * 0.6;
            main.view_2.Width = main.border_4.Width * 0.25;
            main.dTPicker_main_DateFrom.FontSize = main.border_4.Height * 0.15;

            main.dTPicker_main_TimeFrom.Height = main.border_4.Height * 0.585;
            main.dTPicker_main_TimeFrom.FontSize = main.border_4.Height * 0.3;
            main.dTPicker_main_TimeFrom.Width = main.border_4.Width * 0.15;

            main.ckbx_GET.MinHeight = main.panel_ThirdAnalyse.Height / 100 * 0.1666;
            main.ckbx_GET.MinWidth = main.panel_ThirdAnalyse.Width / 100 * 0.1666;
            main.ckbx_GET.LayoutTransform = new ScaleTransform(main.panel_ThirdAnalyse.Width * 0.0060606, main.panel_ThirdAnalyse.Height / 140.0);
            main.ckbx_GET.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_GET.Width = main.panel_ThirdAnalyse.Width * 0.04137;
            main.ckbx_GET.Height = main.panel_ThirdAnalyse.Height * 0.04137;

            main.txt_bl_GET.Height = main.panel_ThirdAnalyse.Height * 0.08;
            main.txt_bl_GET.Width = main.panel_ThirdAnalyse.Width * 0.7;
            main.txt_bl_GET.FontSize = main.Height * 0.025;
            main.txt_bl_GET.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.ckbx_POST.MinHeight = main.panel_ThirdAnalyse.Height / 100 * 0.1666;
            main.ckbx_POST.MinWidth = main.panel_ThirdAnalyse.Width / 100 * 0.1666;
            main.ckbx_POST.LayoutTransform = new ScaleTransform(main.panel_ThirdAnalyse.Width * 0.0060606, main.panel_ThirdAnalyse.Height / 140.0);
            main.ckbx_POST.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_POST.Width = main.panel_ThirdAnalyse.Width * 0.04137;
            main.ckbx_POST.Height = main.panel_ThirdAnalyse.Height * 0.04137;

            main.txt_bl_POST.Height = main.panel_ThirdAnalyse.Height * 0.08;
            main.txt_bl_POST.Width = main.panel_ThirdAnalyse.Width * 0.7;
            main.txt_bl_POST.FontSize = main.Height * 0.025;
            main.txt_bl_POST.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.ckbx_HEAD.MinHeight = main.panel_ThirdAnalyse.Height / 100 * 0.1666;
            main.ckbx_HEAD.MinWidth = main.panel_ThirdAnalyse.Width / 100 * 0.1666;
            main.ckbx_HEAD.LayoutTransform = new ScaleTransform(main.panel_ThirdAnalyse.Width * 0.0060606, main.panel_ThirdAnalyse.Height / 140.0);
            main.ckbx_HEAD.Margin = new Thickness(main.Width * 0.02, 0, 0, 0);
            main.ckbx_HEAD.Width = main.panel_ThirdAnalyse.Width * 0.04137;
            main.ckbx_HEAD.Height = main.panel_ThirdAnalyse.Height * 0.04137;

            main.txt_bl_HEAD.Height = main.panel_ThirdAnalyse.Height * 0.08;
            main.txt_bl_HEAD.Width = main.panel_ThirdAnalyse.Width * 0.7;
            main.txt_bl_HEAD.FontSize = main.Height * 0.025;
            main.txt_bl_HEAD.Margin = new Thickness(main.Width * 0.01, 0, 0, 0);

            main.txt_bl_ErrorCode.FontSize = main.Height * 0.025;
            main.combo_Analysis.FontSize = main.Height * 0.02;
            main.combo_Analysis.Height = main.Height * 0.04;

            main.icon_error.Width = main.panel_FourthAnalyse.Height * 0.15;
            main.icon_error.Height = main.panel_FourthAnalyse.Height * 0.15;
            main.txtbox_Analysis.Height = main.panel_FourthAnalyse.Height * 0.15;
            main.txtbox_Analysis.Width = main.panel_FourthAnalyse.Width * 0.7;
            main.txtbox_Analysis.FontSize = main.panel_FourthAnalyse.Height * 0.07;

            main.test1.Text = "WebLog-ETL";
        }
        
        public void SetSettingSizes()
        {
            settings.Width = settings.CurrentWindowWidth * 0.3;
            settings.Height = settings.CurrentWindowHeight * 0.3;

            settings.settings_row_def_1_1.Height = new GridLength(10, GridUnitType.Star);
            settings.settings_row_def_1_2.Height = new GridLength(90, GridUnitType.Star);

            settings.settings_column_def_1_1.Width = new GridLength(90, GridUnitType.Star);
            settings.settings_column_def_1_2.Width = new GridLength(5, GridUnitType.Star);
            settings.settings_column_def_1_3.Width = new GridLength(5, GridUnitType.Star);

            settings.settings_txt_bl_Head.FontSize = settings.Height * 0.07;
            settings.settings_txt_bl_Head.Margin = new Thickness(settings.Width * 0.1, 0, 0, 0);

            settings.btnExit.Width = settings.Height * 0.07;
            settings.btnExit.Height = settings.Height * 0.07;
            settings.btnExit.Margin = new Thickness(0, settings.Height * 0.01, 0, 0);

            settings.settings_icon_exit.Width = settings.Height * 0.07;
            settings.settings_icon_exit.Height = settings.Height * 0.07;
            settings.settings_icon_exit.Margin = new Thickness(-(settings.Height * 0.045), -(settings.Height * 0.03), -(settings.Height * 0.045), -(settings.Height * 0.03));

            settings.btnMin.Width = settings.Height * 0.07;
            settings.btnMin.Height = settings.Height * 0.07;
            settings.btnMin.Margin = new Thickness(0, settings.Height * 0.01, 0, 0);

            settings.settings_icon_min.Width = settings.Height * 0.07;
            settings.settings_icon_min.Height = settings.Height * 0.07;
            settings.settings_icon_min.Margin = new Thickness(-(settings.Height * 0.047), -(settings.Height * 0.03), -(settings.Height * 0.047), -(settings.Height * 0.03));

            settings.settings_panel.Height = settings.Height * 0.85;
            settings.settings_row_def_2_1.Height = new GridLength(27, GridUnitType.Star);
            settings.settings_row_def_2_2.Height = new GridLength(27, GridUnitType.Star);
            settings.settings_row_def_2_3.Height = new GridLength(27, GridUnitType.Star);
            settings.settings_row_def_2_4.Height = new GridLength(19, GridUnitType.Star);

            settings.settings_viewbox_createDB.Height = settings.settings_panel.Height * 0.27;
            settings.settings_viewbox_selectDB.Height = settings.settings_panel.Height * 0.27;
            settings.settings_viewbox_TextBox.Height = settings.settings_panel.Height * 0.27;
            settings.settings_viewbox_apply.Height = settings.settings_panel.Height * 0.19;

            settings.btnCreateDB.Width = settings.Width * 0.7;
            settings.btnCreateDB.Height = settings.settings_panel.Height * 0.2;
            settings.btnCreateDB.Margin = new Thickness(0, settings.settings_panel.Height * 0.03, 0, 0);
            settings.settings_grid_createDB.Width = settings.btnCreateDB.Width;
            settings.settings_grid_createDB.Height = settings.btnCreateDB.Height;

            settings.settings_column_def_2_1.Width = new GridLength(17, GridUnitType.Star);
            settings.settings_column_def_2_2.Width = new GridLength(83, GridUnitType.Star);

            settings.settings_icon_addDB.Height = settings.btnCreateDB.Height;
            settings.settings_icon_addDB.Width = settings.btnCreateDB.Height;

            settings.settings_txt_bl_createNewDB.Height = settings.btnCreateDB.Height * 0.6;
            settings.settings_txt_bl_createNewDB.Width = settings.btnCreateDB.Width * 0.8;
            settings.settings_txt_bl_createNewDB.Margin = new Thickness(0, settings.btnCreateDB.Height * 0.16, 0, 0);
            settings.settings_txt_bl_createNewDB.FontSize = settings.btnCreateDB.Height * 0.5;

            settings.btnSelectDB.Width = settings.Width * 0.7;
            settings.btnSelectDB.Height = settings.settings_panel.Height * 0.2;
            settings.settings_grid_selectDB.Width = settings.btnSelectDB.Width;
            settings.settings_grid_selectDB.Height = settings.btnSelectDB.Height;

            settings.settings_column_def_3_1.Width = new GridLength(17, GridUnitType.Star);
            settings.settings_column_def_3_2.Width = new GridLength(83, GridUnitType.Star);

            settings.settings_icon_selectDB.Height = settings.btnSelectDB.Height;
            settings.settings_icon_selectDB.Width = settings.btnSelectDB.Height;

            settings.settings_txt_bl_selectDB.Height = settings.btnSelectDB.Height * 0.6;
            settings.settings_txt_bl_selectDB.Width = settings.btnSelectDB.Width * 0.8;
            settings.settings_txt_bl_selectDB.Margin = new Thickness(0, settings.btnSelectDB.Height * 0.16, 0, 0);
            settings.settings_txt_bl_selectDB.FontSize = settings.btnSelectDB.Height * 0.5;

            settings.settings_border.Height = settings.settings_panel.Height * 0.2;
            settings.settings_border.Width = settings.Width * 0.7;

            settings.settings_column_def_4_1.Width = new GridLength(17, GridUnitType.Star);
            settings.settings_column_def_4_2.Width = new GridLength(83, GridUnitType.Star);

            settings.settings_icon_DBLocation.Height = settings.settings_border.Height * 0.95;
            settings.settings_icon_DBLocation.Width = settings.settings_border.Height * 0.95;

            settings.textBoxSelectedDB.Height = settings.settings_border.Height * 0.90;
            settings.textBoxSelectedDB.Width = settings.settings_border.Width * 0.8;
            settings.textBoxSelectedDB.FontSize = settings.settings_border.Height * 0.5;

            settings.settings_grid_apply_cancel.Width = settings.Width * 0.8;

            settings.settings_column_def_5_1.Width = new GridLength(50, GridUnitType.Star);
            settings.settings_column_def_5_2.Width = new GridLength(50, GridUnitType.Star);

            settings.settings_btn_apply.Width = settings.Width * 0.2;
            settings.settings_btn_apply.Height = settings.settings_panel.Height * 0.1;
            settings.settings_btn_apply.Margin = new Thickness(0, 0, settings.settings_btn_apply.Width * 0.075, settings.settings_btn_apply.Height * 0.1);
            settings.settings_grid_apply.Width = settings.settings_btn_apply.Width;
            settings.settings_grid_apply.Height = settings.settings_btn_apply.Height;

            settings.settings_column_def_6_1.Width = new GridLength(45, GridUnitType.Star);
            settings.settings_column_def_6_2.Width = new GridLength(55, GridUnitType.Star);

            settings.settings_icon_apply.Height = settings.settings_btn_apply.Height;
            settings.settings_icon_apply.Width = settings.settings_btn_apply.Height;

            settings.settings_txt_bl_apply.Height = settings.settings_btn_apply.Height * 0.6;
            settings.settings_txt_bl_apply.Width = settings.settings_btn_apply.Width * 0.35;
            settings.settings_txt_bl_apply.Margin = new Thickness(0, settings.settings_btn_apply.Height * 0.16, 0, 0);
            settings.settings_txt_bl_apply.FontSize = settings.settings_btn_apply.Height * 0.5;

            settings.settings_btn_cancel.Width = settings.Width * 0.2;
            settings.settings_btn_cancel.Height = settings.settings_panel.Height * 0.1;
            settings.settings_btn_cancel.Margin = new Thickness(settings.settings_btn_apply.Width * 0.075, 0, 0, settings.settings_btn_cancel.Height * 0.1);
            settings.settings_grid_cancel.Width = settings.settings_btn_apply.Width;
            settings.settings_grid_cancel.Height = settings.settings_btn_cancel.Height;

            settings.settings_column_def_7_1.Width = new GridLength(45, GridUnitType.Star);
            settings.settings_column_def_7_2.Width = new GridLength(55, GridUnitType.Star);

            settings.settings_icon_cancel.Height = settings.settings_btn_cancel.Height;
            settings.settings_icon_cancel.Width = settings.settings_btn_cancel.Height;

            settings.settings_txt_bl_cancel.Height = settings.settings_btn_cancel.Height * 0.6;
            settings.settings_txt_bl_cancel.Width = settings.settings_btn_cancel.Width * 0.35;
            settings.settings_txt_bl_cancel.Margin = new Thickness(0, settings.settings_btn_cancel.Height * 0.16, 0, 0);
            settings.settings_txt_bl_cancel.FontSize = settings.settings_btn_cancel.Height * 0.5;
        }

        public void SetImportSizes()
        {
            import.Width = import.CurrentWindowWidth * 0.7;
            import.Height = import.CurrentWindowHeight * 0.7;

            import.import_row_def_1_1.Height = new GridLength(5, GridUnitType .Star);
            import.import_row_def_1_2.Height = new GridLength(5, GridUnitType.Star);
            import.import_row_def_1_3.Height = new GridLength(90, GridUnitType.Star);

            import.import_column_def_1_1.Width = new GridLength(90, GridUnitType.Star);
            import.import_column_def_1_2.Width = new GridLength(3, GridUnitType.Star);
            import.import_column_def_1_3.Width = new GridLength(3, GridUnitType.Star);

            import.import_txt_bl_Head.Height = import.Height * 0.0425;
            import.import_txt_bl_Head.FontSize = import.Height * 0.0325;
            import.import_txt_bl_Head.Margin = new Thickness(import.Width * 0.08, 0, 0, import.Height * 0.0425);

            import.import_btn_exit.Width = import.Height * 0.04;
            import.import_btn_exit.Height = import.Height * 0.04;
            import.import_btn_exit.Margin = new Thickness(0, 0, 0, import.Height * 0.0375);

            import.import_icon_exit.Width = import.Height * 0.04;
            import.import_icon_exit.Height = import.Height * 0.04;
            import.import_icon_exit.Margin = new Thickness(-(import.Height * 0.02), -(import.Height * 0.02), -(import.Height * 0.02), -(import.Height * 0.02));

            import.import_btn_min.Width = import.Height * 0.04;
            import.import_btn_min.Height = import.Height * 0.04;
            import.import_btn_min.Margin = new Thickness(0, 0, 0, import.Height * 0.0375);

            import.import_icon_min.Width = import.Height * 0.04;
            import.import_icon_min.Height = import.Height * 0.04;
            import.import_icon_min.Margin = new Thickness(-(import.Height * 0.02), -(import.Height * 0.02), -(import.Height * 0.02), -(import.Height * 0.02));

            import.import_panel_row_1.Height = import.Height * 0.05;
            import.import_panel_row_1.Width = import.Width * 0.98;

            import.import_column_def_2_1.Width = new GridLength(70, GridUnitType.Star);
            import.import_column_def_2_2.Width = new GridLength(15, GridUnitType.Star);
            import.import_column_def_2_3.Width = new GridLength(15, GridUnitType.Star);

            import.import_panel_column_0.Width = import.Width * 0.7;

            import.import_viewbox_startImport.Height = import.import_panel_row_1.Height;
            import.import_viewbox_startImport.Width = import.import_panel_row_1.Width * 0.17;
            import.import_viewbox_openFile.Height = import.import_panel_row_1.Height;
            import.import_viewbox_openFile.Width = import.import_panel_row_1.Width * 0.17;

            import.import_btn_startImport.Width = import.Width * 0.13;
            import.import_btn_startImport.Height = import.import_panel_row_1.Height * 0.7;
            import.import_btn_startImport.Margin = new Thickness(0, import.import_panel_row_1.Height * 0.175, 0, 0);
            import.import_grid_startImport.Width = import.import_btn_startImport.Width;
            import.import_grid_startImport.Height = import.import_btn_startImport.Height;

            import.import_column_def_3_1.Width = new GridLength(28, GridUnitType.Star);
            import.import_column_def_3_2.Width = new GridLength(72, GridUnitType.Star);

            import.import_icon_startImport.Height = import.import_btn_startImport.Height;
            import.import_icon_startImport.Width = import.import_btn_startImport.Height;

            import.import_txt_bl_startImport.Height = import.import_btn_startImport.Height * 0.6;
            import.import_txt_bl_startImport.Width = import.import_btn_startImport.Width * 0.8;
            import.import_txt_bl_startImport.Margin = new Thickness(0, import.import_btn_startImport.Height * 0.16, 0, 0);
            import.import_txt_bl_startImport.FontSize = import.import_btn_startImport.Height * 0.5;

            import.import_btn_openFile.Width = import.Width * 0.13;
            import.import_btn_openFile.Height = import.import_panel_row_1.Height * 0.7;
            import.import_btn_openFile.Margin = new Thickness(0, import.import_panel_row_1.Height * 0.175, 0, 0);
            import.import_grid_openFile.Width = import.import_btn_openFile.Width;
            import.import_grid_openFile.Height = import.import_btn_openFile.Height;

            import.import_column_def_4_1.Width = new GridLength(28, GridUnitType.Star);
            import.import_column_def_4_2.Width = new GridLength(72, GridUnitType.Star);

            import.import_icon_openFile.Height = import.import_btn_openFile.Height;
            import.import_icon_openFile.Width = import.import_btn_openFile.Height;

            import.import_txt_bl_openFile.Height = import.import_btn_openFile.Height * 0.6;
            import.import_txt_bl_openFile.Width = import.import_btn_openFile.Width * 0.8;
            import.import_txt_bl_openFile.Margin = new Thickness(0, import.import_btn_openFile.Height * 0.16, 0, 0);
            import.import_txt_bl_openFile.FontSize = import.import_btn_openFile.Height * 0.5;

            import.import_border.Height = import.Height * 0.88;
            import.import_border.Width = import.Width * 0.98;

            import.import_datagrid_ip.Width = (import.import_border.Width - 5) / 6;
            import.import_datagrid_dt_event.Width = (import.import_border.Width - 5) / 6;
            import.import_datagrid_event.Width = (import.import_border.Width - 5) / 6;
            import.import_datagrid_status.Width = (import.import_border.Width - 5) / 6;
            import.import_datagrid_typ.Width = (import.import_border.Width - 5) / 6;
            import.import_datagrid_number.Width = (import.import_border.Width - 5) / 6;
        }

        public void SetInformationSizes()
        {
            information.Width = information.CurrentWindowWidth * 0.5;
            information.Height = information.CurrentWindowHeight * 0.6;

            information.information_column_def_1_1.Width = new GridLength(30, GridUnitType.Star);
            information.information_column_def_1_2.Width = new GridLength(70, GridUnitType.Star);

            information.information_row_def_1_1.Height = new GridLength(10, GridUnitType.Star);
            information.information_row_def_1_2.Height = new GridLength(90, GridUnitType.Star);

            //information.information_panel_header.Height = information.Height * 0.04;
            //information.information_panel_header.Margin = new Thickness(0, -0.5, 0, 0);

            information.information_column_def_2_1.Width = new GridLength(90, GridUnitType.Star);
            information.information_column_def_2_2.Width = new GridLength(5, GridUnitType.Star);
            information.information_column_def_2_3.Width = new GridLength(5, GridUnitType.Star);

            information.information_txt_bl_Head.Height = information.Height * 0.0425;
            information.information_txt_bl_Head.FontSize = information.Height * 0.0325;
            information.information_txt_bl_Head.Margin = new Thickness(information.Width * 0.08, 0, 0, information.Height * 0.0425);

            information.information_btn_exit.Width = information.Height * 0.04;
            information.information_btn_exit.Height = information.Height * 0.04;
            information.information_btn_exit.Margin = new Thickness(0, 0, 0, information.Height * 0.0375);

            information.information_icon_exit.Width = information.Height * 0.04;
            information.information_icon_exit.Height = information.Height * 0.04;
            information.information_icon_exit.Margin = new Thickness(-(information.Height * 0.0225), -(information.Height * 0.0225), -(information.Height * 0.0225), -(information.Height * 0.0225));

            information.information_btn_min.Width = information.Height * 0.04;
            information.information_btn_min.Height = information.Height * 0.04;
            information.information_btn_min.Margin = new Thickness(0, 0, 0, information.Height * 0.0375);

            information.information_icon_min.Width = information.Height * 0.04;
            information.information_icon_min.Height = information.Height * 0.04;
            information.information_icon_min.Margin = new Thickness(-(information.Height * 0.0225), -(information.Height * 0.0225), -(information.Height * 0.0225), -(information.Height * 0.0225));
        }
    }
}
