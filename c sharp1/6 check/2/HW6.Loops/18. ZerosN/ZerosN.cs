using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;

class ZerosN
{
    static void Main()
    {
        Console.Write("Enter number for 'n': ");
        int number = int.Parse(Console.ReadLine());
       
        int zeros = 0;
        int five = 5;
       
        while (five < number)
        {
            zeros += number / five;
            five = five * 5;
        }
        Console.WriteLine(zeros);
    }
}
