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
        public class ImportData
        {
            public string IP { set; get; }
            public string DT_EVENT { set; get; }
            public string TYP { set; get; }
            public string EVENT { set; get; }
            public string STATUS { set; get; }
            public string Number { set; get; }
            public string MDHASH { set; get; }

        }

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
            string Insert = "INSERT INTO Logs (IP, DT_EVENT, TYP, EVENT, Status, Byte, Hash) Values ";
            foreach (ImportData row in ImportDatas)
            {
                if (row != null)
                {
                    Insert += "('" + row.IP + "','" + row.DT_EVENT + "','" + row.TYP + "','" + row.EVENT + "','" + row.STATUS+ "','" + row.Number + "','" + row.MDHASH + "'),";
                }
            }
            DBHandler.NonQuery(Insert.Remove(Insert.Length - 1, 1) + ";");
            DBHandler.NonQuery("INSERT INTO ImportedFiles (Name, FileHash) VALUES ('"+ OpenedFile + "' , '" + GetFilekMD5(OpenedFile) + "');");
            MessageBox.Show("done");
        }

        List<ImportData> ImportDatas = new List<ImportData>();

        private void CreateDataGridFromFile(string path)
        {
            if (Properties.Settings.Default.DB_FILE != "")
            {
                using (System.IO.StreamReader logStream = System.IO.File.OpenText(path))
                {

                    while (!logStream.EndOfStream)
                    {

                        ImportDatas = HandleLine(logStream.ReadLine(), ImportDatas);

                    }
                    import_DataGrid.ItemsSource = ImportDatas;
                }
            }
            else { MessageBox.Show("Bitte zuerst in den Einstellungen eine Datenbank auswählen oder erstellen!"); }
        }

        private List<ImportData> HandleLine(string logLine, List<ImportData> ImportDatas)
        {
            string eventCode = GetLogEventCode(logLine);
      
            ImportDatas.Add(new ImportData() { IP = GetIP(logLine), DT_EVENT = GetDateTime(logLine), TYP = eventCode, EVENT = GetLogEvent(logLine, eventCode), STATUS = GetStatusCode(logLine), Number = GetLastCode(logLine), MDHASH = GetStringMD5(logLine) });
            
            DoEvents();
            return ImportDatas;
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
            if (Properties.Settings.Default.DB_FILE != "")
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
                        this.IsEnabled = false;
                        CreateDataGridFromFile(openFileDialog.FileName);
                        this.IsEnabled = true;                    
                    }
                    else
                    { MessageBox.Show("Diese Datei wurde bereits importiert!"); }
                }
            }
            else { MessageBox.Show("Bitte zuerst in den Einstellungen eine Datenbank auswählen oder erstellen!"); }

        }

        private void btn_import_ImportStart_Click(object sender, EventArgs e)
        {
            if (OpenedFile != null && import_DataGrid.Items.Count > 1)
            {
                this.IsEnabled = false;
                WriteToDb();
                this.IsEnabled = true;
                this.Owner.IsEnabled = true;
                this.Owner.Activate();
                this.Close();
            }
        }

        private void btn_import_Close(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.IsEnabled = true;
            this.Owner.Activate();
        }

        private void btn_import_Min(object sender, EventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton.ToString() == "Left")
            {
                DragMove();
            }
        }
    }
}
