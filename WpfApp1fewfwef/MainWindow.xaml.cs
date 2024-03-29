﻿using System;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;


namespace WpfApp1fewfwef
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool mRestoreIfMove = false;
        private readonly Binding binding = new Binding();
        Scaling scaling = new Scaling();
        
        public int CurrentWindowWidth = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenWidth * 0.8));
        public int CurrentWindowHeight = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenHeight * 0.8));
        public MainWindow()
        {
            InitializeComponent();
            scaling.main = this;
            scaling.SetSizes();
            test.Items.Add("Analyse 1");
            test.Items.Add("Analyse 2");
            test.Items.Add("Analyse 3");
            test.Items.Add("Analyse 4");
            test.SelectedIndex = 0;
            //MessageBox.Show((this.Height * 0.0436).ToString());
        }
        private void Window_Deactivated(object sender, EventArgs e)
        {
            Window window = (Window)sender;
            //window.Topmost = true;
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
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
                scaling.main = this;
                scaling.SetSizes();
                this.WindowState = WindowState.Maximized;
            }
            else if (this.WindowState == WindowState.Maximized)
            {
                this.CurrentWindowWidth = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenWidth * 0.8));
                this.CurrentWindowHeight = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenHeight * 0.8));
                scaling.SetSizes();
                this.WindowState = WindowState.Normal;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {         
            if(e.ChangedButton.ToString()=="Left")
            {
                DragMove();
            }            
        }

        private void btn_Settings_Click(object sender, RoutedEventArgs e)
        {
            this.IsEnabled = false;
            Settings settings = new Settings();
            settings.Owner = this;
            settings.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        private void ExecuteQuery(string query)
        {
            DataGrid.DataContext = DBHandler.ExecuteQuery(query);
        }

        private string GetDateTAndIpSelection()
        {
            string whereS = "";
            if(dTPicker_main_DateFrom.SelectedDate != null && dTPicker_main_TimeFrom.SelectedTime != null && dTPicker_main_DateUntil.SelectedDate != null && dTPicker_main_TimeUntil != null)
            {
                try
                {
                    whereS = " WHERE DT_EVENT > '" + dTPicker_main_DateFrom.SelectedDate.Value.ToString("yyyy-MM-dd") + " " + dTPicker_main_TimeFrom.SelectedTime.Value.ToString("HH:mm:ss") + "' AND DT_EVENT < '" + dTPicker_main_DateUntil.SelectedDate.Value.ToString("yyyy-MM-dd") + " " + dTPicker_main_TimeUntil.SelectedTime.Value.ToString("HH:mm:ss") + "'";
                }
                catch
                {
                    MessageBox.Show("Zeitraumfilter sind nicht aktiv, um diese zu aktivieren füllen Sie bitte alle dazugehörigen Felder.");
                }    
            }else if (dTPicker_main_DateFrom.SelectedDate != null)
            {
                string time = "";
                if (dTPicker_main_TimeFrom.SelectedTime != null) { time = dTPicker_main_TimeFrom.SelectedTime.Value.ToString("HH:mm:ss"); }
                whereS = " WHERE DT_EVENT > '" + dTPicker_main_DateFrom.SelectedDate.Value.ToString("yyyy-MM-dd") + " " + time + "'";
            }
            else if (dTPicker_main_DateUntil.SelectedDate != null)
            {
                string time = "";
                if (dTPicker_main_TimeUntil.SelectedTime != null) { time = dTPicker_main_TimeUntil.SelectedTime.Value.ToString("HH:mm:ss"); }
                whereS = " WHERE DT_EVENT < '" + dTPicker_main_DateUntil.SelectedDate.Value.ToString("yyyy-MM-dd") + " " + time + "'";
            }


            if (txt_bl_IP_In.Text != "")
            {
                if (whereS == "") { whereS = " WHERE IP IN (" + "'" + txt_bl_IP_In.Text.Replace(",", "','") + "')"; }
                else { whereS += " AND IP IN (" + "'" + txt_bl_IP_In.Text.Replace(",", "','") + "')"; }
            }
            //MessageBox.Show(whereS);
            return whereS;
        }

        private void btn_main_Import_Click(object sender, EventArgs e)
        {
            Import import = new Import();
            import.Owner = this;
            this.IsEnabled = false;
            import.Show();
        }

        private void btn_main_Load_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT * FROM ImportedFiles");
        }

        private void btn_main_LoadData_FirstAnalyse_Click()
        {
            if (ckbx_IP.IsChecked.Value || ckbx_Timestamp.IsChecked.Value || ckbx_Method.IsChecked.Value || ckbx_Event.IsChecked.Value || ckbx_Status.IsChecked.Value || ckbx_Number.IsChecked.Value)
            {
                string whereS = GetDateTAndIpSelection();
                string selection = "";
                if (ckbx_IP.IsChecked.Value) selection += "IP,";
                if (ckbx_Timestamp.IsChecked.Value) selection += "DT_EVENT,";
                if (ckbx_Method.IsChecked.Value) selection += "TYP,";
                if (ckbx_Event.IsChecked.Value) selection += "EVENT,";
                if (ckbx_Status.IsChecked.Value) selection += "Status,";
                if (ckbx_Number.IsChecked.Value) selection += "Byte,";

                selection = selection.Substring(0, selection.Length - 1);

                ExecuteQuery("SELECT " + selection + " FROM Logs " + whereS);
            }
            else { MessageBox.Show("Bitte mindestens ein Attribut wählen!"); }
        }

        private void cb_main_Date_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckbx_Timestamp.IsChecked.Value) { grpBox_main_ZeitRaum.Enabled = true; }
            //else { grpBox_main_ZeitRaum.Enabled = false; }
        }

        private void btn_main_LoadData_SecondAnalyse_Click()
        {
            ExecuteQuery("SELECT IP, COUNT(*) as Anzahl FROM Logs " + GetDateTAndIpSelection() + " GROUP BY IP");
        }

        private void btn_main_LoadData_ThirdAnalyse_Click()
        {
            
            if (ckbx_GET.IsChecked.Value || ckbx_POST.IsChecked.Value || ckbx_HEAD.IsChecked.Value)
            {
                string whereS = GetDateTAndIpSelection();
                string method = "";
                if (ckbx_GET.IsChecked.Value) { method = "'GET',"; }
                if (ckbx_POST.IsChecked.Value) { method += "'POST',"; }
                if (ckbx_HEAD.IsChecked.Value) { method += "'HEAD',"; }

                method = " TYP IN (" + method.Substring(0, method.Length - 1) + ") ";

                if (whereS != "") { whereS += " AND " + method; }
                else { whereS = "WHERE" + method; }

                ExecuteQuery("SELECT TYP as Methode, COUNT(*) as Anzahl FROM Logs " + whereS + " GROUP BY TYP");
            }
            else { MessageBox.Show("Bitte mindestens eine Methode auswählen."); }
        }

        private void btn_main_LoadData_FourthAnalyse_Click()
        {
            string whereS = GetDateTAndIpSelection();
            
            if (txtbox_Analysis.Text != "")
            {
                if (whereS == "") { whereS = " WHERE Status IN (" + "'" + txtbox_Analysis.Text.Replace(",", "','") + "')"; }
                else { whereS += " AND Status IN (" + "'" + txtbox_Analysis.Text.Replace(",", "','") + "')"; }
            }
            ExecuteQuery("SELECT Status as Error, COUNT(*) as Anzahl FROM Logs " + whereS + " GROUP BY Status");
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {          
            if(test.Text == "Analyse 1") { btn_main_LoadData_FirstAnalyse_Click(); }
            if (test.Text == "Analyse 2") { btn_main_LoadData_SecondAnalyse_Click(); }
            if (test.Text == "Analyse 3") { btn_main_LoadData_ThirdAnalyse_Click(); }
            if (test.Text == "Analyse 4") { btn_main_LoadData_FourthAnalyse_Click(); }
        }

        private void txt_bl_IP_In_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int CaretIndex = txt_bl_IP_In.CaretIndex;
            string allowedCharacters = "0123456789,.";
            if (allowedCharacters.Contains(e.Text))
            {
                txt_bl_IP_In.Text = txt_bl_IP_In.Text.Insert(txt_bl_IP_In.CaretIndex,e.Text);
            }
            e.Handled = true;
            txt_bl_IP_In.CaretIndex = CaretIndex + 1;
        }

        private void txt_bl_IP_In_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Space)
            {
                e.Handled=true;
            }
        }

        private void btn_Information_Click(object sender, RoutedEventArgs e)
        {
            Information information = new Information();
            information.Owner=this;
            this.IsEnabled = false;
            information.Show();
        }

        private void txt_bl_IP_In_LostFocus(object sender, RoutedEventArgs e)
        {
            string Message = "";
            foreach(string a in txt_bl_IP_In.Text.Split(',',StringSplitOptions.RemoveEmptyEntries))
            {
                if(!IPAddress.TryParse(a,out IPAddress ipAddress)||a.Split('.').Length-1!=3) 
                {
                    Message += a + "\n";
                }
            }
            if (Message.Length > 0)
            {
                if(MessageBox.Show("Die folgenden IP Adressen sind nicht valide:\n\n" + Message + "\nSollen die IP Adressen entfernt werden?", "Invalide IP Adressen", MessageBoxButton.YesNo)==MessageBoxResult.Yes) {
                    foreach (string a in Message.Split('\n',StringSplitOptions.RemoveEmptyEntries))
                    {
                        try { txt_bl_IP_In.Text = txt_bl_IP_In.Text.Replace(a + ",", "");
                            txt_bl_IP_In.Text = txt_bl_IP_In.Text.Replace(a , ""); }
                        catch { txt_bl_IP_In.Text = txt_bl_IP_In.Text.Replace(a, ""); }
                    }
                }
            }           
        }

        private void btn_clear_date_filter_Click(object sender, RoutedEventArgs e)
        {
            this.dTPicker_main_TimeUntil.SelectedTime = null;
            this.dTPicker_main_DateUntil.SelectedDate = null;
            this.dTPicker_main_TimeFrom.SelectedTime = null;
            this.dTPicker_main_DateFrom.SelectedDate = null;
        }

        private void btn_clear_ip_filter_Click(object sender, RoutedEventArgs e)
        {
            this.txt_bl_IP_In.Clear();
        }
    }
}