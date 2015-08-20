using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;

//Download and install this: http://www.microsoft.com/en-us/download/confirmation.aspx?id=13255 and http://www.microsoft.com/en-us/download/details.aspx?id=23734
namespace _6.ExelReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = string.Format(@"{0}\..\..\score.xlsx", Directory.GetCurrentDirectory());

            DataSet sheet1 = new DataSet();
            OleDbConnectionStringBuilder connestionString = new OleDbConnectionStringBuilder();
            connestionString.Provider = "Microsoft.ACE.OLEDB.12.0";
            connestionString.DataSource = filePath;
            connestionString.Add("Extended Properties", "Excel 12.0 Xml;HDR=YES");

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
    }
}
