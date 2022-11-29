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
        #region Methods
        public SettingsForm()
        {
            InitializeComponent();
            txtBox_settings_SelectedDB.Text = Properties.Settings.Default.DB_FILE;
        }

        private void CreateTables()
        {
            DBHandler.NonQuery("CREATE TABLE ImportedFiles( ID INTEGER PRIMARY KEY AUTOINCREMENT, FileHash VARCHAR(32), Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP);");
            DBHandler.NonQuery("CREATE TABLE Logs ( ID INTEGER PRIMARY KEY   AUTOINCREMENT, Hash VARCHAR(32) NOT NULL, TimestampInsert DATETIME DEFAULT CURRENT_TIMESTAMP, IP TEXT(128), DT_EVENT DATETIME, TYP VARCHAR(32), EVENT TEXT(8192), Status INTEGER, Number INTEGER);");
        }

        private bool CheckDbSchema(string dbPath)
        {
            string oldFilePath = Properties.Settings.Default.DB_FILE;
            Properties.Settings.Default.DB_FILE = dbPath;
            string dbConnection = @"Data Source=" + dbPath + ";Version=3;New=True;Compress=True;";
            DataTable checkTable = DBHandler.ExecuteQuery("SELECT * FROM sqlite_master WHERE type = 'table' ORDER BY 1");
            DataRow[] tableInfos = checkTable.Select("name IN ('Logs','ImportedFiles')");
            if (tableInfos.Length!=2){ Properties.Settings.Default.DB_FILE = oldFilePath; return false; }
            if (tableInfos[0][4].ToString()!= "CREATE TABLE ImportedFiles( ID INTEGER PRIMARY KEY AUTOINCREMENT, FileHash VARCHAR(32), Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP)") { Properties.Settings.Default.DB_FILE = oldFilePath; return false; }
            if (tableInfos[1][4].ToString()!= "CREATE TABLE Logs ( ID INTEGER PRIMARY KEY   AUTOINCREMENT, Hash VARCHAR(32) NOT NULL, TimestampInsert DATETIME DEFAULT CURRENT_TIMESTAMP, IP TEXT(128), DT_EVENT DATETIME, TYP VARCHAR(32), EVENT TEXT(8192), Status INTEGER, Number INTEGER)") { Properties.Settings.Default.DB_FILE = oldFilePath; return false; }
            
            return true;
        }
        #endregion Methods
        #region Events
        private void btn_settings_CreateNewDB_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Datenbank (*.db)|*.db",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog.FileName, new string[0]);
            }

            Properties.Settings.Default.DB_FILE = saveFileDialog.FileName;
            CreateTables();
            txtBox_settings_SelectedDB.Text = Properties.Settings.Default.DB_FILE;
        }

        private void btn_settings_SelectDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Datenbank (*.db)|*.db",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if(!CheckDbSchema(openFileDialog.FileName))
                {
                    MessageBox.Show("Diese Datenbank ist nicht kompatibel");
                }
                else
                {
                    Properties.Settings.Default.DB_FILE = openFileDialog.FileName;
                }                
            }
            txtBox_settings_SelectedDB.Text = Properties.Settings.Default.DB_FILE;
        }
        #endregion Events
    }
}