using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter decimal numb: ");
        long decNumb = long.Parse(Console.ReadLine());

        string hexNumb = decNumb.ToString("X");
        long hexa = long.Parse(hexNumb, NumberStyles.HexNumber);

        Console.WriteLine(hexNumb);
    }
}
