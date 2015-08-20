//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class IfPrime
{
    static void Main()
    {
        Console.Title = "Is the number prime?";
        Console.Write("Please enter a number between 1 and 100: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        if ((number >= 1) && (number <= 100))
        {
            if ((number == 2 || number == 3 || number == 5 || number == 7) 
                || !(number % 2 == 0 || number % 3 == 0 || number % 5 == 0 || number % 7 == 0) && number != 1)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime");
            }
        }
        else
        {
            Console.WriteLine("Number is out of range");
        }
    }
}