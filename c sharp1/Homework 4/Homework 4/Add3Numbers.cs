using System;

class Add3Numbers
{
    //Write a program that reads 3 real numbers from the console and prints their sum.

    static void Main()
    {
        int number1, number2, number3;

        Console.Title = "Sum of 3 numbers";
        Console.Write("Please enter first number: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number1))
                break;
            else
                Console.WriteLine("Please enter an integer number");
        }

        Console.Write("Please enter second number: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number2))
                break;
            else
                Console.WriteLine("Please enter an integer number");
        }

        Console.Write("Please enter thirth number: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out number3))
                break;
            else
                Console.WriteLine("Please enter an integer number");
        }

        Console.WriteLine("The sum is: {0}", number1+number2+number3);
    }
}
