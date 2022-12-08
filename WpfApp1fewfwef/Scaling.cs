﻿using System;
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
        public MainWindow main = null;

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

            main.row_def_3_1.Height = new GridLength(4.457, GridUnitType.Star);
            main.row_def_3_2.Height = new GridLength(69.979, GridUnitType.Star);
            main.row_def_3_2.Height = new GridLength(25.564, GridUnitType.Star);

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
    }
}
