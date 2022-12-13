using System.Windows;
using System.Data;
using System.Security.Cryptography;
using System.IO;
using Microsoft.Win32;
using System.Windows.Input;
using System;

namespace WpfApp1fewfwef
{
    /// <summary>
    /// Interaktionslogik für Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public int CurrentWindowWidth = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenWidth * 0.8));
        public int CurrentWindowHeight = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenHeight * 0.8));
        Scaling scaling = new Scaling();
        public Settings()
        {
            InitializeComponent();
            textBoxSelectedDB.Text = WpfApp1fewfwef.Properties.Settings.Default.DB_FILE;
            scaling.settings = this;
            scaling.SetSettingSizes();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {            
            this.Close();
            this.Owner.IsEnabled = true;
            this.Owner.Activate();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnCreateDB_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Datenbank (*.db)|*.db",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            bool? result = saveFileDialog.ShowDialog();
            if (result == true)
            {
                System.IO.File.WriteAllLines(saveFileDialog.FileName, new string[0]);
                Properties.Settings.Default.DB_FILE = saveFileDialog.FileName;
                CreateTables();
                textBoxSelectedDB.Text = Properties.Settings.Default.DB_FILE;
                textBoxSelectedDB.ToolTip = textBoxSelectedDB.Text;
            }
        }
               

        private void btnSelectDB_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Datenbank (*.db)|*.db",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                if (!CheckDbSchema(openFileDialog.FileName))
                {
                    MessageBox.Show("Diese Datenbank ist nicht kompatibel");
                }
                else
                {
                    Properties.Settings.Default.DB_FILE = openFileDialog.FileName;
                }
                textBoxSelectedDB.Text = Properties.Settings.Default.DB_FILE;
                textBoxSelectedDB.ToolTip = textBoxSelectedDB.Text;
            }            
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton.ToString()=="Left")
            {
                DragMove();
            }
        }

        private void CreateTables()
        {
            DBHandler.NonQuery("CREATE TABLE ImportedFiles( ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT,FileHash VARCHAR(32), Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP);");
            DBHandler.NonQuery("CREATE TABLE Logs ( ID INTEGER PRIMARY KEY   AUTOINCREMENT, Hash VARCHAR(32) NOT NULL, TimestampInsert DATETIME DEFAULT CURRENT_TIMESTAMP, IP TEXT(128), DT_EVENT DATETIME, TYP VARCHAR(32), EVENT TEXT(8192), Status INTEGER, Byte INTEGER);");
        }

        private bool CheckDbSchema(string dbPath)
        {
            string oldFilePath = Properties.Settings.Default.DB_FILE;
            Properties.Settings.Default.DB_FILE = dbPath;
            string dbConnection = @"Data Source=" + dbPath + ";Version=3;New=True;Compress=True;";
            DataTable checkTable = DBHandler.ExecuteQuery("SELECT * FROM sqlite_master WHERE type = 'table' ORDER BY 1");
            DataRow[] tableInfos = checkTable.Select("name IN ('Logs','ImportedFiles')");
            if (tableInfos.Length != 2) { Properties.Settings.Default.DB_FILE = oldFilePath; return false; }
            if (tableInfos[0][4].ToString() != "CREATE TABLE ImportedFiles( ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT,FileHash VARCHAR(32), Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP)") { Properties.Settings.Default.DB_FILE = oldFilePath; return false; }
            if (tableInfos[1][4].ToString() != "CREATE TABLE Logs ( ID INTEGER PRIMARY KEY   AUTOINCREMENT, Hash VARCHAR(32) NOT NULL, TimestampInsert DATETIME DEFAULT CURRENT_TIMESTAMP, IP TEXT(128), DT_EVENT DATETIME, TYP VARCHAR(32), EVENT TEXT(8192), Status INTEGER, Byte INTEGER)") { Properties.Settings.Default.DB_FILE = oldFilePath; return false; }

            return true;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.IsEnabled = true;
        }
    }
}