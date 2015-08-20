//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class DidgitCheck
{
    static void Main()
    {
        int number;
        Console.Title = "Check if 3-th didgit is 7";
        Console.Write("Please enter a number:\t");
        while (true)//endles cycle (repeated untill break)
        {
            if (int.TryParse(Console.ReadLine(), out number))//Parses input for integer values and returns true or false
            {
                int result = (number / 100) % 10;

                bool check = (Math.Abs(result) == 7);
                Console.WriteLine(check);
                break;
            }
            else
            {
                Console.WriteLine("\nPlease enter an integer number");
            }
        }   
    }
}
