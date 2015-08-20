using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "hello";
            string world = "World";
            object concatenation = hello + " " + world;
            string result = (string)concatenation;
            //string result = concatenation.Tostring;??
            Console.WriteLine(result);
        }
    }
}
