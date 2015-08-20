using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecToBin
{
    static void Main()
    {
        Console.Write("Enter decimal numb: ");
        long decNumb = long.Parse(Console.ReadLine());
 
        long result;
        string binaryNumb = string.Empty;
 
        while (decNumb > 0)
        {
            result = decNumb % 2;
            decNumb /= 2;
            binaryNumb = result.ToString() + binaryNumb;
        }
        Console.WriteLine(binaryNumb);
    }
}
