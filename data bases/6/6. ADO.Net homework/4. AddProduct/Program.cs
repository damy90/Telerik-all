using System;
using System.Data.SqlClient;
using System.Linq;

namespace _4.AddProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbConn = new SqlConnection("Server=.; Database=Northwind; Integrated Security = true");

            dbConn.Open();
            using (dbConn)
            {
                SqlParameter paramName = new SqlParameter();
                paramName.ParameterName = "@addedProduct";
                paramName.Value = "Groq";

                SqlParameter paramPrice = new SqlParameter();
                paramPrice.ParameterName = "@pricePerUnit";
                paramPrice.Value = 0.0m;

                SqlParameter paramCategoryId = new SqlParameter();
                paramCategoryId.ParameterName = "@category";
                paramCategoryId.Value = 1;

                SqlCommand getCategories = new SqlCommand(
                    "INSERT INTO Products (ProductName, UnitPrice, CategoryID) " +
                    "VALUES (@addedProduct, @pricePerUnit, @category)", dbConn);

                getCategories.Parameters.Add(paramName);
                getCategories.Parameters.Add(paramPrice);
                getCategories.Parameters.Add(paramCategoryId);

                int rows = getCategories.ExecuteNonQuery();
                if (rows == 1)
                {
                    Console.WriteLine("Product successfully added.");
                }
                else
                {
                    Console.WriteLine("Could not add product!");
                }
            }
        }
    }
}
