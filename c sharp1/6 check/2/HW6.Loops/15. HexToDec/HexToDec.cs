using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HexToDec
    {
        static void Main()
        {
            Console.Write("Enter hexadecimal value: ");
            string hexNumb = Console.ReadLine();

            long decNumb = long.Parse(hexNumb, NumberStyles.HexNumber);

            Console.WriteLine(decNumb);
        }
    }

