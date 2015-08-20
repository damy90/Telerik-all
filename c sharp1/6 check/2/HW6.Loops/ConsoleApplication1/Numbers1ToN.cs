using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Numbers1ToN
{
    static void Main()
    {
        Console.Write("Enter number for 'n': ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
