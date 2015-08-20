using System;
using System.Numerics;

class Combinatorics
{
    //In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    //Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
    static void Main()
    {
        Console.Title = "N!/K!*(N-K)!,  1 < k < n < 100";

        int n;
        Console.Write("Please enter value for N: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n) && n > 2)
                break;
            Console.Write("Please enter a positive integer number > 2: ");
        }
        int k;
        Console.Write("Please enter value for K: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out k) && k > 1 && k < n)
                break;
            Console.Write("Please enter a positive integer number between 1 and {0}: ", n);
        }
        
        BigInteger nMinusKFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nFactorial = 1;
        for (int i = 2; i <= n; i++)
        {
            nFactorial *= i;
            if (i == n - k)
                nMinusKFactorial = nFactorial;

            if (i == k)
                kFactorial = nFactorial;
        }

        BigInteger result = nFactorial / (kFactorial * nMinusKFactorial);
        
        Console.WriteLine("The result is: {0}", result);
    }
}