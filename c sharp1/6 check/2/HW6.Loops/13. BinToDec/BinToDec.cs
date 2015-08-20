using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinToDec
{
    static void Main()
    {
        Console.Write("Enter binary numb: ");
        string binaryNumb = Console.ReadLine();

        long decNumb = 0;

        for (int i = 0; i < binaryNumb.Length; i++)
        {
            if (binaryNumb[binaryNumb.Length - i - 1] == '0')
            {
                continue;
            }
            decNumb += (long)Math.Pow(2, i);
        }
        Console.WriteLine(decNumb);
    }
}
