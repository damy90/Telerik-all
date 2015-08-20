using System;

class NFactorialoverKFactorial
{
    //Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    //Use only one loop.
    static void Main()
    {
        Console.Title = "N!/K!  1<K<N<100";

        int n;
        Console.Write("Please enter value for N: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n) && n > 2 && n<100)
                break;
            Console.Write("Please enter a positive integer number larger than 2: ");
        }

        int k;
        Console.Write("Please enter value for K: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out k) && k > 1 && k < n)
                break;
            Console.Write("Please enter a positive integer number smaller than N and larger tahan 1: ");
        }

        ulong result=1;
        for (int i = k+1; i <= n; i++)
            result = checked(result * (ulong)i);
        Console.WriteLine("The result is: {0}", result);
    }
}
