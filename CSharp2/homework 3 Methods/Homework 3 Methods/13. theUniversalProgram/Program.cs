using System;
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
class Program
{
    static void Main()
    {
        Console.WriteLine("Please choose an option:\nr to reverse the didgits of a number\na to calculate the average of a sequence of integers\ns to solve a*x+b=0");
        char choice = Console.ReadKey().KeyChar;
        switch (choice)
        {
            case 'r':
            case 'R':
                Reverse();
                break;
            case 'a':
            case 'A':
                Average();
                break;
            case 's':
            case 'S':
                Solve();
                break;
        }
    }

    static void Reverse()
    {
        Console.Write("\nPlease enter a number: ");
        int number=ValidIntInput(0);//call input and validation
        char[] digits = number.ToString().ToCharArray();
        Array.Reverse(digits);
        Console.Write("The Reverse is: ");
        foreach (char didgit in digits)
            Console.Write(didgit);
        Console.WriteLine();
    }

    static void Average()
    {
        Console.Write("\nPlease enter number count: ");
        int sequenceSize= ValidIntInput(0);
        int sum = 0;
        for (int i = 0; i < sequenceSize; i++)
            sum+= ValidIntInput();
        Console.WriteLine("Average= {0}", sum / sequenceSize);
    }

    static void Solve()
    {
        Console.Write("\nPlease enter value for a: ");
        int a = ValidNonZeroIntInput();
        Console.Write("Please enter value for b: ");
        int b = ValidIntInput();
        Console.WriteLine("x= {0}", -b / a);
    }
    //general input and validation (may accept minimal value
    static int ValidIntInput(int min=int.MinValue)
    {
        int value;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out value) && value > min)
                break;
            Console.Write("Please enter an integer value greater than {0}: ", min);
        }
        return value;
    }
    //input and validation (excludes a single value)
    static int ValidNonZeroIntInput()
    {
        int value;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out value) && value != 0)
                break;
            Console.Write("Please enter an integer nonzero value: ");
        }
        return value;
    }
}