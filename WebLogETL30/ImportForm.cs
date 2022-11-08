using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace WebLogETL30
{
    public partial class ImportForm : Form
    {
        private string OpenedFile;
        public ImportForm()
        {
            InitializeComponent();
        }


        private void WriteToDb()
        {
            string Insert = "INSERT INTO Logs (IP, DT_EVENT, TYP, EVENT, Status, Number, Hash) Values ";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                    Insert += ("('"+row.Cells[0].Value+ "','" + row.Cells[1].Value + "','" + row.Cells[2].Value + "','" + row.Cells[3].Value + "','" + row.Cells[4].Value + "','" + row.Cells[5].Value + "','" + row.Cells[6].Value + "'),");
            }
            DBHandler.NonQuery(Insert.Remove(Insert.Length - 1, 1) + ";") ;
            DBHandler.NonQuery("INSERT INTO ImportedFiles (FileHash) VALUES ('" + GetFilekMD5(OpenedFile) + "');");
            MessageBox.Show("done");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            dataGridView1.Rows.Add(GetIP(logLine), GetDateTime(logLine), eventCode, GetLogEvent(logLine, eventCode), GetStatusCode(logLine), GetLastCode(logLine), GetStringMD5(logLine));
            Application.DoEvents();
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Log (*.log)|*.log";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                OpenedFile = openFileDialog1.FileName;
                if (DBHandler.ExecuteQuery("SELECT * FROM ImportedFiles WHERE FileHash = '" + GetFilekMD5(openFileDialog1.FileName) + "'").Rows.Count == 0)
                {
                    CreateDataGridFromFile(openFileDialog1.FileName);
                    MessageBox.Show("done");
                }
                else
                {
                    MessageBox.Show("Diese Datei wurde bereits importiert!");
                }
               
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (OpenedFile != null && dataGridView1.Rows.Count > 1)
            {
                WriteToDb();
                this.Close();
            }
        }

        private string GetStringMD5(string s)
        {

            StringBuilder builder = new StringBuilder();

            foreach (byte b in System.Security.Cryptography.MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(s)))
                builder.Append(b.ToString("x2").ToLower());

            return builder.ToString();
        }

        private string GetFilekMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

    }
}
