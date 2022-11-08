using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebLogETL30
{

    
    public partial class Form1 : Form
    {
        private BindingSource bindingSource1 = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImportForm importForm = new ImportForm();
            importForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            SettingsForm settingsform = new SettingsForm();
            settingsform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            bindingSource1.DataSource = DBHandler.ExecuteQuery("SELECT * FROM ImportedFiles");
            dataGridView1.DataSource = bindingSource1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbIP.Checked || cbTime.Checked ||cbMeth.Checked||cbEvent.Checked|| cbStatus.Checked|| cbNummer.Checked )
            {
                string whereS = GetDateTAndIpSelection();

                string selection = "";
                if (cbIP.Checked) selection += "IP,";
                if (cbTime.Checked) selection += "DT_EVENT,";
                if (cbMeth.Checked) selection += "TYP,";
                if (cbEvent.Checked) selection += "EVENT,";
                if (cbStatus.Checked) selection += "Status,";
                if (cbNummer.Checked) selection += "Number,";

                selection = selection.Substring(0, selection.Length - 1);

                ExecuteQuery("SELECT " + selection + " FROM Logs " + whereS);

            }
            else
            {
                MessageBox.Show("Bitte mindestens ein Attribut wählen!");
            }
        }

        private void ExecuteQuery(string query)
        {
            bindingSource1.DataSource = DBHandler.ExecuteQuery(query);
            dataGridView1.DataSource = bindingSource1;
        }

        private void cbDt_CheckedChanged(object sender, EventArgs e)
        {
            if(cbDt.Checked) { groupBox2.Enabled = true; }
            else { groupBox2.Enabled = false; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecuteQuery("SELECT IP, COUNT(*) as Anzahl FROM Logs " + GetDateTAndIpSelection() + " GROUP BY IP");
        }

        private string GetDateTAndIpSelection()
        {
            string whereS = "";
            if (cbDt.Checked)
            {
                whereS = " WHERE DT_EVENT > '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " " + dateTimePicker2.Value.ToString("HH:mm:ss") + "' AND DT_EVENT < '" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + " " + dateTimePicker4.Value.ToString("HH:mm:ss") + "'";

            }

            if ((tbIP.Text) != "")
            {
                if (whereS == "") { whereS = " WHERE IP IN (" + "'" + tbIP.Text.Replace(",", "','") + "')"; }
                else { whereS += " AND IP IN (" + "'" + tbIP.Text.Replace(",", "','") + "')"; }
            }

            return whereS;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbGet.Checked || cbPost.Checked || cbHead.Checked)
            {
                string whereS = GetDateTAndIpSelection();
                string method = "";
                if (cbGet.Checked) { method = "'GET',"; }
                if (cbPost.Checked) { method += "'POST',"; }
                if (cbHead.Checked) { method += "'HEAD',"; }

                method = " TYP IN (" + method.Substring(0, method.Length - 1) + ") ";

                if (whereS != "") { whereS += " AND " + method; }
                else { whereS = "WHERE" + method; }

                ExecuteQuery("SELECT TYP as Methode, COUNT(*) as Anzahl FROM Logs " + whereS + " GROUP BY TYP");
            }
            else
            {
                MessageBox.Show("Bitte mindestens eine Methode auswählen.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string whereS = GetDateTAndIpSelection();

            if ((tbError.Text) != "")
            {
                if (whereS == "") { whereS = " WHERE Status IN (" + "'" + tbError.Text.Replace(",", "','") + "')"; }
                else { whereS += " AND Status IN (" + "'" + tbError.Text.Replace(",", "','") + "')"; }
            }



            ExecuteQuery("SELECT Status as Error, COUNT(*) as Anzahl FROM Logs " + whereS + " GROUP BY Status");

        }
    }
}
