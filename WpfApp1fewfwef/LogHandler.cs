using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Threading;

namespace WebLogETL30
{
    class LogHandler
    {
        public DataGrid dataTable = new DataGrid();
        public LogHandler(string path)
        {
            CreateDataGridFromFile(path);
        }

        public struct MyData
        {
            public string IP { get; set; }
            public string DateTime { get; set; }
            public string RequestType { get; set; }
            public string Request { get; set; }
            public string RequestStatus { get; set; }
            public string Code { get; set; }
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
            string[] Clms = { "IP", "DateTime", "RequestType", "Request", "RequestStatus", "Code" };
            foreach (string Clm in Clms)
            {
                DataGridTextColumn textColumn = new DataGridTextColumn();
                textColumn.Header = Clm;
                textColumn.Binding = new Binding(Clm);
                dataTable.Columns.Add(textColumn);
            }
        }

        private void HandleLine(string logLine)
        {
            //Richtige Zuordnung der Columns ?

            dataTable.Items.Add(new MyData { IP = GetIP(logLine), DateTime = GetDateTime(logLine), Request = GetLogEventCode(logLine), RequestStatus = GetLogEvent(logLine, GetLogEventCode(logLine)), RequestType = GetStatusCode(logLine), Code = GetLastCode(logLine) });
            //dataTable.Rows.Add(GetIP(logLine), GetDateTime(logLine), GetLogEventCode(logLine), GetLogEvent(logLine, GetLogEventCode(logLine)), GetStatusCode(logLine), GetLastCode(logLine));
            DoEvents();
        }
        public static void DoEvents()
        {
            Application.Current.Dispatcher.Invoke(DispatcherPriority.Render,
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
            //int endIndex = logLine.Substring(startIndex, logLine.Length).IndexOf(']');
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
            return logLine.Split(' ')[logLine.Split(' ').Length - 1];
        }

        private string GetLastCode(string logLine)
        {
            return logLine.Split(' ')[logLine.Split(' ').Length - 1];
        }
    }
}