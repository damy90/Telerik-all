using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfNumbs
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number >= 20)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = row; col < number + row; col++)
                {
                    Console.Write("{0,2} ", col);
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}