using System;

class Program
{
    static void Main()
    {
        int number;
        Console.Title = "Divide by 5 and 7";
        Console.WriteLine("Please enter a number");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("This number is {0}", (number % 2 == 0) ? "even{0}" : "odd");
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter an integer number");
            }
        }
    }
}

