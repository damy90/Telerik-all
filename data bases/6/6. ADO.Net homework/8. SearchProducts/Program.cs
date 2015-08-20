using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;

namespace _8.SearchProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbConn = new SqlConnection("Server=.; Database=Northwind; Integrated Security = true");

            string searchedString = Console.ReadLine();

            if (Regex.IsMatch(searchedString, "[^0-9a-zA-Z]", RegexOptions.CultureInvariant))
            {
                searchedString = string.Format("[{0}]", searchedString);
            }


            dbConn.Open();
            using (dbConn)
            {
                SqlParameter searchParameter = new SqlParameter();
                searchParameter.ParameterName = "@searchParameter";
                searchParameter.Value = string.Format("%{0}%", searchedString);


                SqlCommand getCategories = new SqlCommand(
                    "SELECT ProductName FROM Products " +
                    "WHERE ProductName LIKE @searchParameter", dbConn);

                getCategories.Parameters.Add(searchParameter);

                var reader = getCategories.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string line = string.Format("{0}", (string)reader["ProductName"]);
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
