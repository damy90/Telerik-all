using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbs
{
    static void Main()
    {
        Console.Write("Enter number for N: ");
        int numbN = int.Parse(Console.ReadLine());

        Console.Write("Enter min number: ");
        int numbMin = int.Parse(Console.ReadLine());

        Console.Write("Enter max number: ");
        int numbMax = int.Parse(Console.ReadLine());

        if (numbMin <= numbMax)
        {
            Random randNumb = new Random();
            for (int i = 0; i < numbN; i++)
            {
                Console.Write(randNumb.Next(numbMin, numbMax + 1) + " "); 
            }
                Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input! You try to set Max value < Min value! Please try again!");
        }
    }
}