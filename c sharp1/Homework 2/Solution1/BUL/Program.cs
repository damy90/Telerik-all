using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            bool isFemale;
            Console.WriteLine("Waht is your gender");
            string MyGender = Console.ReadLine();
            if (MyGender == "female")
            {
                isFemale = true;
            }
            else
            {
                isFemale = false;
            }
        }
    }
}
