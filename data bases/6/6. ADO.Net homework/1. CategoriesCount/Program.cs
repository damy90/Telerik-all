using System;
using System.Data.SqlClient;
using System.Linq;

namespace _1.CategoriesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbConn = new SqlConnection("Server=.; Database=Northwind; Integrated Security = true");

            dbConn.Open();

            using (dbConn)
            {
                SqlCommand getCategoriesCount = new SqlCommand("SELECT COUNT(*) FROM Categories", dbConn);

                int categoriesCount = (int)getCategoriesCount.ExecuteScalar();

                Console.WriteLine("Number of categories: {0}", categoriesCount);
            }
        }
    }
}
