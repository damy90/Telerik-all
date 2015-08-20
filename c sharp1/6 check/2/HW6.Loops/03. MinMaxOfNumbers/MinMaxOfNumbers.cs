using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MinMaxOfNumbers
{
    static void Main()
    {
        Console.Write("Enter the total numbers:");
        int n = int.Parse(Console.ReadLine());
        int[] arrNumbs = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter {0} number: ", i + 1);
            arrNumbs[i] = int.Parse(Console.ReadLine());
        }

        int min = arrNumbs[0];
        int max = arrNumbs[0];
        int sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arrNumbs[i];
            if (min > arrNumbs[i])
                min = arrNumbs[i];
            if (max < arrNumbs[i])
                max = arrNumbs[i];
        }
        average = (double)sum / n;

        Console.WriteLine();
        Console.WriteLine("Min\t: {0}", min);
        Console.WriteLine("Max\t: {0}", max);
        Console.WriteLine("Sum\t: {0}", sum);
        Console.WriteLine("Average\t: {0,2:n}", average);
    }
}

