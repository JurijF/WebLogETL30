using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebLogETL30
{
    public partial class Main : Form
    {
        #region Methods
        private readonly BindingSource bindingSource = new BindingSource();
        public Main()
        {
            InitializeComponent();
        }

        private void ExecuteQuery(string query)
        {
            bindingSource.DataSource = DBHandler.ExecuteQuery(query);
            dataGrid_main_MainGrid.DataSource = bindingSource;
        }

        private string GetDateTAndIpSelection()
        {
            string whereS = "";
            if (cb_main_Date.Checked)
            {
                whereS = " WHERE DT_EVENT > '" + dTPicker_main_DateFrom.Value.ToString("yyyy-MM-dd") + " " + dTPicker_main_TimeFrom.Value.ToString("HH:mm:ss") + "' AND DT_EVENT < '" + dTPicker_main_DateUntil.Value.ToString("yyyy-MM-dd") + " " + dTPicker_main_TimeUntil.Value.ToString("HH:mm:ss") + "'";
            }

            if (tb_main_IP.Text != "")
            {
                if (whereS == "") { whereS = " WHERE IP IN (" + "'" + tb_main_IP.Text.Replace(",", "','") + "')"; }
                else { whereS += " AND IP IN (" + "'" + tb_main_IP.Text.Replace(",", "','") + "')"; }
            }
            return whereS;
        }
        #endregion Methods
        #region Events
        private void btn_main_Import_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.Show();
        }

        private void btn_main_Settings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsform = new SettingsForm();
            settingsform.Show();
        }

        private void btn_main_Load_Click(object sender, EventArgs e)
        {          
            bindingSource.DataSource = DBHandler.ExecuteQuery("SELECT * FROM ImportedFiles");
            dataGrid_main_MainGrid.DataSource = bindingSource;
        }

        private void btn_main_LoadData_FirstAnalyse_Click(object sender, EventArgs e)
        {
            if (cb_main_IP.Checked || cb_main_Time.Checked || cb_main_Method.Checked|| cb_main_Event.Checked || cb_main_Status.Checked || cb_main_Nummer.Checked )
            {
                string whereS = GetDateTAndIpSelection();
                string selection = "";
                if (cb_main_IP.Checked) selection += "IP,";
                if (cb_main_Time.Checked) selection += "DT_EVENT,";
                if (cb_main_Method.Checked) selection += "TYP,";
                if (cb_main_Event.Checked) selection += "EVENT,";
                if (cb_main_Status.Checked) selection += "Status,";
                if (cb_main_Nummer.Checked) selection += "Number,";

                selection = selection.Substring(0, selection.Length - 1);

                ExecuteQuery("SELECT " + selection + " FROM Logs " + whereS);
            }
            else { MessageBox.Show("Bitte mindestens ein Attribut wählen!"); }
        }

        private void cb_main_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_main_Date.Checked) { grpBox_main_ZeitRaum.Enabled = true; }
            else { grpBox_main_ZeitRaum.Enabled = false; }
        }

        private void btn_main_LoadData_SecondAnalyse_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT IP, COUNT(*) as Anzahl FROM Logs " + GetDateTAndIpSelection() + " GROUP BY IP");
        }

        private void btn_main_LoadData_ThirdAnalyse_Click(object sender, EventArgs e)
        {
            if (cb_main_Get.Checked || cb_main_Post.Checked || cb_main_Head.Checked)
            {
                string whereS = GetDateTAndIpSelection();
                string method = "";
                if (cb_main_Get.Checked) { method = "'GET',"; }
                if (cb_main_Post.Checked) { method += "'POST',"; }
                if (cb_main_Head.Checked) { method += "'HEAD',"; }

                method = " TYP IN (" + method.Substring(0, method.Length - 1) + ") ";

                if (whereS != "") { whereS += " AND " + method; }
                else { whereS = "WHERE" + method; }

                ExecuteQuery("SELECT TYP as Methode, COUNT(*) as Anzahl FROM Logs " + whereS + " GROUP BY TYP");
            }
            else { MessageBox.Show("Bitte mindestens eine Methode auswählen."); }
        }

        private void btn_main_LoadData_FourthAnalyse_Click(object sender, EventArgs e)
        {
            string whereS = GetDateTAndIpSelection();

            if (tb_main_Error.Text != "")
            {
                if (whereS == "") { whereS = " WHERE Status IN (" + "'" + tb_main_Error.Text.Replace(",", "','") + "')"; }
                else { whereS += " AND Status IN (" + "'" + tb_main_Error.Text.Replace(",", "','") + "')"; }
            }

            ExecuteQuery("SELECT Status as Error, COUNT(*) as Anzahl FROM Logs " + whereS + " GROUP BY Status");
        }
        #endregion Events
    }
}