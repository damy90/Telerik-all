using System;
using System.Linq;
using MySql.Data.MySqlClient;
using System.IO;

namespace _9.BooksDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connToMySql = @"Server=localhost;Uid=root;Pwd=root;Allow User Variables=True;";

            MySqlConnection connect = new MySqlConnection("Server=localhost;Uid=root;Pwd=root;Allow User Variables=True;");

            connect.Open();
        }
    }
}
