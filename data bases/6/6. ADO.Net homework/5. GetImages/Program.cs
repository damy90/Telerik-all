using System;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;

namespace _5.GetImages
{
    class Program
    {
        static void Main(string[] args)
        {
            int fileOffset = 78;

            SqlConnection dbConn = new SqlConnection("Server=.; Database=Northwind; Integrated Security=true");

            dbConn.Open();
            using (dbConn)
            {
                SqlCommand command = new SqlCommand(
                    "SELECT CategoryName, Picture " +
                    "FROM Categories", dbConn);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        string categoryName = ((string)reader["CategoryName"]);
                        categoryName = categoryName.Replace('/', ' ');

                        byte[] pictureBytes = reader["Picture"] as byte[];

                        MemoryStream stream = new MemoryStream(
                            pictureBytes, fileOffset,
                            pictureBytes.Length - fileOffset);

                        Image image = Image.FromStream(stream);
                        using (image)
                        {
                            image.Save(@"..\..\images\" + categoryName + ".jpg", ImageFormat.Jpeg);
                        }
                    }

                    Console.WriteLine("Images are in the images folder");
                }
            }
        }
    }
}
