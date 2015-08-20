using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NotDivisible3and7
{
    static void Main()
    {
        Console.Write("Enter number for 'n': ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine();

        for (int i = 1; i <= number; i++)
        {
            if (((i % 3) != 0) && ((i % 7) != 0))
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
