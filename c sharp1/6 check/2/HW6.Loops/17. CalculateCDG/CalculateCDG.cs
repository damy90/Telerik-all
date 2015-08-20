using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateCDG
{
    static void Main()
    {
        Console.Write("Enter number for 'a' = ");
        int numberA = int.Parse(Console.ReadLine());

        Console.Write("Enter number for 'b' = ");
        int numberB = int.Parse(Console.ReadLine());

        int numberC = 0;

        while (numberB != 0)
        {
            numberC = numberB;
            numberB = numberA % numberB;
            numberA = numberC;
        }
        Console.WriteLine("");
        Console.WriteLine("GCD from 'a'and'b' is {0}", numberA);
    }
}
