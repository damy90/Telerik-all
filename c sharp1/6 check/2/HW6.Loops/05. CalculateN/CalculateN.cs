using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculateN
{
    static void Main()
    {
        Console.Write("Enter number for 'n': ");
        int numbN = int.Parse(Console.ReadLine());
      
        Console.Write("Enter number for 'x': ");
        int numbX = int.Parse(Console.ReadLine());
       
        double result = 1.00;
        double factorialSum = 1.00;
        double tempDivide = 1.00;
        
        for (int i = 1; i <= numbN; i++)
        {
            // double factorial = 0.0;
            factorialSum *= i;
            tempDivide = tempDivide * numbN;
            result += factorialSum / tempDivide;
        }
        Console.WriteLine("{0: 0.00000}", result);
    }
}
