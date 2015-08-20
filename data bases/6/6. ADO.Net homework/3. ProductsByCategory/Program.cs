using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.ProductsByCategory
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbConn = new SqlConnection("Server=.; Database=Northwind; Integrated Security = true");

            dbConn.Open();

            SqlCommand getProductsByCategory = new SqlCommand(
                    "SELECT cat.CategoryName, prod.ProductName FROM Categories cat " +
                    "JOIN Products prod " +
                    "ON cat.CategoryID = prod.CategoryID " +
                    "GROUP BY CategoryName, prod.ProductName", dbConn);

            SqlDataReader reader = getProductsByCategory.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string line = string.Format("{0, -20} - {1, -20}",
                        (string)reader["CategoryName"] + ":",
                        (string)reader["ProductName"]);
                    Console.WriteLine(line);
                }
            }
        }
    }
}
