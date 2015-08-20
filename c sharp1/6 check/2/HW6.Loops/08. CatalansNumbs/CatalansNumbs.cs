using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CatalansNumbs
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (1 < number && number < 100)
        {
            BigInteger numerator = 1;
            BigInteger denominator = 1;
            BigInteger result = 1;
            for (int k = 2; k <= number; k++)
            {
                numerator *= number + k;
                denominator *= k;
            }
            result = numerator / denominator;
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("out of range");
        }
    }
}

