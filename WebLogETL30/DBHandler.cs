using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;
namespace WebLogETL30
{
    class DBHandler 
    {
        public static void NonQuery(string squery)
        {
            string connection = @"Data Source="+ Properties.Settings.Default.DB_FILE + ";Version=3;New=True;Compress=True;";
            SQLiteConnection sqlite_conn = new SQLiteConnection(connection);
            
            sqlite_conn.Open();
            var SqliteCmd = sqlite_conn.CreateCommand();
            SqliteCmd.CommandText = squery;
            SqliteCmd.ExecuteNonQuery();
            sqlite_conn.Close();
        }

        public static DataTable ExecuteQuery(string squery)
        {
            SQLiteDataReader sqlite_datareader;
            DataTable queryDG = new DataTable();

            string connection = @"Data Source=" + Properties.Settings.Default.DB_FILE + ";Version=3;New=True;Compress=True;";
            SQLiteConnection sqlite_conn = new SQLiteConnection(connection);
            
            sqlite_conn.Open();
            var SqliteCmd = sqlite_conn.CreateCommand();
            SqliteCmd.CommandText = squery;
            sqlite_datareader = SqliteCmd.ExecuteReader();

            for (int i = 0; i < sqlite_datareader.FieldCount; i++)
            {
                queryDG.Columns.Add(sqlite_datareader.GetName(i));
            }
            
            sqlite_datareader.Close();
            sqlite_datareader = SqliteCmd.ExecuteReader();

            while (sqlite_datareader.Read())
            {
                List<string> dataRows = new List<string>();
                for (int i = 0; i < sqlite_datareader.FieldCount; i++)
                {
                    dataRows.Add(sqlite_datareader.GetValue(i).ToString());        
                }
                queryDG.Rows.Add(dataRows.ToArray());
            }
            sqlite_conn.Close();

            return queryDG;
        }
    }
}