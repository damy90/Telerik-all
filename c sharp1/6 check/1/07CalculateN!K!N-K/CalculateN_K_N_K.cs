/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.*/

using System;
class CalculateN_K_N_K
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        bool inRange = n < 100 && k > 1 && n > k;

        if (inRange)
        {
            double nFactorial = 1;
            double kFactorial = 1;
            double differenceFactorial = 1;
            double result = 0;

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;

                if (i <= k)
                {
                    kFactorial *= i;
                }
            }
            for (int i = 1; i <= n - k; i++)
            {
                differenceFactorial *= i;
            }

            result = nFactorial / (kFactorial * differenceFactorial);
            Console.WriteLine("{0}", result);
        }
        else
        {
            Console.WriteLine("Invalid input. Correct input --> 1 < k < n < 100");
        }
    }
}