using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;

namespace _7.ExelWriterAddRows
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileName = string.Format(@"{0}\..\..\score.xlsx", Directory.GetCurrentDirectory());

            OleDbConnectionStringBuilder conString = new OleDbConnectionStringBuilder();
            conString.Provider = "Microsoft.ACE.OLEDB.12.0";
            conString.DataSource = fileName;
            conString.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES");

            string name = "Homer Simpson", score = "-3";
            AppendRow(conString, name, score);

            PrintSpreadsheet(conString);
        }

        private static void PrintSpreadsheet(OleDbConnectionStringBuilder connestionString)
        {
            DataSet sheet1 = new DataSet();
            using (OleDbConnection connection = new OleDbConnection(connestionString.ConnectionString))
            {
                connection.Open();
                string selectSql = @"SELECT * FROM [Sheet1$]";
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectSql, connection))
                {
                    adapter.Fill(sheet1);
                }
                connection.Close();
            }
            
            var table = sheet1.Tables[0];

            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    Console.Write("{0, -20} ", row[column]);
                }

                Console.WriteLine();
            }
        }

        private static void AppendRow(OleDbConnectionStringBuilder conString, string name, string score)
        {
            using (OleDbConnection connection = new OleDbConnection(conString.ConnectionString))
            {
                connection.Open();

                string queryText = @"INSERT INTO [Sheet1$] (Name, Score) VALUES (@Name, @Score)";
                using (OleDbCommand oleDbCmd = connection.CreateCommand())
                {
                    oleDbCmd.CommandType = CommandType.Text;
                    oleDbCmd.CommandText = queryText;
                    oleDbCmd.Parameters.AddWithValue("@Name", name);
                    oleDbCmd.Parameters.AddWithValue("@Score", score);
                    oleDbCmd.ExecuteNonQuery();
                }
            }
        }
    }
}
