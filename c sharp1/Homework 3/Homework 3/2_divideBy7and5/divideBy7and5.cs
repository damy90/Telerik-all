//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7and5
{
    static void Main()
    {
        int number;
        Console.Title = "Can the number divide by 7 and 5?";
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

