using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumber1toN
{
    static void Main()
    {
        Console.Write("Enter number for N: ");
        int numbN = int.Parse(Console.ReadLine());

        Random randNumb = new Random();

        for (int i = 1; i < numbN; i++)
        {
            Console.Write(randNumb.Next(1, numbN + 1) + " ");
        }
        Console.WriteLine();
    }
}
