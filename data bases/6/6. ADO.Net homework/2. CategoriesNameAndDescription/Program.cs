using System;
using System.Data.SqlClient;
using System.Linq;

namespace _2.GetCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbConn = new SqlConnection("Server=.; Database=Northwind; Integrated Security = true");

            dbConn.Open();

            using (dbConn)
            {
                SqlCommand getCategories = new SqlCommand("SELECT CategoryName, Description FROM Categories", dbConn);

                SqlDataReader reader = getCategories.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        string line = string.Format("{0, -20}{1, -20}", (string)reader["CategoryName"]+":", (string)reader["Description"]);
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
