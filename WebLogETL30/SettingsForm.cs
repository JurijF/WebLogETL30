using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WebLogETL30
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.DB_FILE;
        }

        private void CreateNewDbBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Datenbank (*.db)|*.db";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog1.FileName, new string[0]);
            }

            
            Properties.Settings.Default.DB_FILE = saveFileDialog1.FileName;
            CreateTables();
            textBox1.Text = Properties.Settings.Default.DB_FILE;

        }

        private void CreateTables()
        {

            DBHandler.NonQuery("CREATE TABLE ImportedFiles( ID INTEGER PRIMARY KEY AUTOINCREMENT, FileHash VARCHAR(32), Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP); ");
            DBHandler.NonQuery("CREATE TABLE Logs ( ID INTEGER PRIMARY KEY   AUTOINCREMENT, Hash VARCHAR(32) NOT NULL, TimestampInsert DATETIME DEFAULT CURRENT_TIMESTAMP, IP TEXT(128), DT_EVENT DATETIME, TYP VARCHAR(32), EVENT TEXT(8192), Status INTEGER, Number INTEGER);");
        }

        private void SelectDbBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Datenbank (*.db)|*.db";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DB_FILE = openFileDialog1.FileName;
            }
            textBox1.Text = Properties.Settings.Default.DB_FILE;
        }
    }
}
