using System;

//check the results with http://www.wolframalpha.com/
//example expression: sum N!/X^N for N=0 to 5, X=5  
//click on "Approximate form"

class Sum
{
    //Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    //Use only one loop. Print the result with 5 digits after the decimal point.
    static void Main()
    {
        Console.Title = "Sum N!/X^N";

        int n;
        Console.Write("Please enter N: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n) && n >= 0)
                break;
            Console.Write("Please enter a positive integer number: ");//fixed
        }

        int x;
        Console.Write("Please enter X: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out x) && x != 0)
                break;
            Console.Write("Please enter a positive integer number: ");
        }

        double result=1, factorial=1, denominator=x;
        for (int i=1; i<=n; i++)
        {
            factorial *= i;
            result = result + (factorial / denominator);
            denominator *= x;
        }

        Console.WriteLine("The result is: {0:0.00000}", result);
    }
}
