using System;

class Program
{
    static void Main()
    {
        int number;
        Console.Title = "Even or odd number";
        Console.WriteLine("Please enter a number");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("The number {0} be divided by 5 and 7 without remainder", ((number % 5 == 0) && (number % 7 == 0)) ? "CAN" : "CANNOT");
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter an integer number");
            }
        }
    }
}

