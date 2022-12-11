using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1fewfwef
{
    /// <summary>
    /// Interaction logic for Import.xaml
    /// </summary>
    public partial class Import : Window
    {
        private string OpenedFile;
        Scaling scaling = new Scaling();
        public int CurrentWindowWidth = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenWidth * 0.8));
        public int CurrentWindowHeight = Convert.ToInt32(Convert.ToDouble(System.Windows.SystemParameters.PrimaryScreenHeight * 0.8));

        public Import()
        {
            InitializeComponent();
            scaling.import = this;
            scaling.SetImportSizes();
        }

        private void WriteToDb()
        {
            string Insert = "INSERT INTO Logs (IP, DT_EVENT, TYP, EVENT, Status, Number, Hash) Values ";
            foreach (DataGrid row in import_DataGrid.Items)
            {
                if (row != null)
                {
                    Insert += "('" + row.Items[0] + "','" + row.Items[1] + "','" + row.Items[2] + "','" + row.Items[3] + "','" + row.Items[4] + "','" + row.Items[5] + "','" + row.Items[6] + "'),";
                }
            }
            DBHandler.NonQuery(Insert.Remove(Insert.Length - 1, 1) + ";");
            DBHandler.NonQuery("INSERT INTO ImportedFiles (FileHash) VALUES ('" + GetFilekMD5(OpenedFile) + "');");
            MessageBox.Show("done");
        }

        private void CreateDataGridFromFile(string path)
        {
            using (System.IO.StreamReader logStream = System.IO.File.OpenText(path))
            {
                while (!logStream.EndOfStream)
                {
                    HandleLine(logStream.ReadLine());
                }
            }
        }

        private void HandleLine(string logLine)
        {
            string eventCode = GetLogEventCode(logLine);
            string[] values = { GetIP(logLine), GetDateTime(logLine), eventCode, GetLogEvent(logLine, eventCode), GetStatusCode(logLine), GetLastCode(logLine), GetStringMD5(logLine) };
            import_DataGrid.Items.Add(new object[] { GetIP(logLine), GetDateTime(logLine), eventCode, GetLogEvent(logLine, eventCode), GetStatusCode(logLine), GetLastCode(logLine), GetStringMD5(logLine) });
            DoEvents();
        }
        public static void DoEvents()
        {
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Background,
                                                  new Action(delegate { }));
        }
        private string GetIP(string logLine)
        {
            return logLine.Split(new string[] { " - - " }, StringSplitOptions.None)[0];
        }

        private string GetDateTime(string logLine)
        {
            int startIndex = logLine.IndexOf('[') + 1;
            int endIndex = logLine.IndexOf(']') - 1;
            return logLine.Substring(startIndex, endIndex - startIndex);
        }

        private string GetLogEventCode(string logLine)
        {
            int startIndex = logLine.IndexOf('"') + 1;
            int endIndex = logLine.Substring(startIndex, logLine.Length - startIndex).IndexOf('"');
            return logLine.Substring(startIndex, endIndex).Split(' ')[0];
        }

        private string GetLogEvent(string logLine, string LogEventCode)
        {
            int startIndex = logLine.IndexOf('"') + 1;
            int endIndex = logLine.Substring(startIndex, logLine.Length - startIndex).IndexOf('"');
            string logEvent = logLine.Substring(startIndex, endIndex);
            return logEvent.Replace(LogEventCode + " ", "");
        }

        private string GetStatusCode(string logLine)
        {
            return logLine.Split(' ')[logLine.Split(' ').Length - 2];
        }

        private string GetLastCode(string logLine)
        {
            return logLine.Split(' ')[logLine.Split(' ').Length - 1];
        }

        private string GetStringMD5(string s)
        {
            StringBuilder builder = new StringBuilder();

            foreach (byte b in System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(s)))
            {
                builder.Append(b.ToString("x2").ToLower());
            }
            return builder.ToString();
        }

        private string GetFilekMD5(string filename)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void btn_import_Load_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Log (*.log)|*.log",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog().Equals(true))
            {
                OpenedFile = openFileDialog.FileName;
                if (DBHandler.ExecuteQuery("SELECT * FROM ImportedFiles WHERE FileHash = '" + GetFilekMD5(openFileDialog.FileName) + "'").Rows.Count == 0)
                {
                    CreateDataGridFromFile(openFileDialog.FileName);
                    MessageBox.Show("done");
                }
                else
                { MessageBox.Show("Diese Datei wurde bereits importiert!"); }
            }
        }

        private void btn_import_ImportStart_Click(object sender, EventArgs e)
        {
            if (OpenedFile != null && import_DataGrid.Items.Count > 1)
            {
                WriteToDb();
                this.Close();
            }
        }

    }
}
