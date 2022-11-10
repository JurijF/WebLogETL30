using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WebLogETL30
{
    class LogHandler 
    {
        public DataGridView dataTable = new DataGridView();
        public LogHandler(string path)
        {
            CreateDataGridFromFile(path);
        }

        public void CreateDataGridFromFile(string path)
        {
            AddClmsToDt();
            using (System.IO.StreamReader logStream = System.IO.File.OpenText(path))
            {
                while (!logStream.EndOfStream)
                {
                    HandleLine(logStream.ReadLine());
                }
            }     
        }

        private void AddClmsToDt()
        {
            string[] Clms= { "IP", "DateTime", "RequestType", "Request", "RequestStatus", "Code"};
            foreach(string Clm in Clms)
            {
                dataTable.Columns.Add(Clm, Clm);
            }
        }

        private void HandleLine(string logLine)
        {
            dataTable.Rows.Add(GetIP(logLine), GetDateTime(logLine), GetLogEventCode(logLine), GetLogEvent(logLine, GetLogEventCode(logLine)), GetStatusCode(logLine), GetLastCode(logLine));
            Application.DoEvents();
        }

        private string GetIP(string logLine)
        {
            return logLine.Split(new string[] { " - - " }, StringSplitOptions.None)[0];
        }

        private string GetDateTime(string logLine)
        {
            int startIndex = logLine.IndexOf('[')+1;
            int endIndex = logLine.IndexOf(']')-1;
            //int endIndex = logLine.Substring(startIndex, logLine.Length).IndexOf(']');
            return logLine.Substring(startIndex, endIndex-startIndex);
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
            return logLine.Split(' ')[logLine.Split(' ').Length - 1];
        }

        private string GetLastCode(string logLine)
        {
            return logLine.Split(' ')[logLine.Split(' ').Length - 1];
        }
    }
}