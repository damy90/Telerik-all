using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter 1-st number");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2-nd number");
            float c = float.Parse(Console.ReadLine());
            bool areEqual = a == c;
            Console.WriteLine(areEqual);
            Console.WriteLine(Console.ReadLine());
        }
    }
}
