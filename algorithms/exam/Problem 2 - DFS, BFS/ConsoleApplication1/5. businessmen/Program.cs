using System;

internal class Businessmen
{
    private static long[] memo;

    internal static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        memo = new long[100];
        Console.WriteLine(SolveRecursively(n));

        Console.WriteLine(SolveIteratively(n));

        Console.WriteLine(SolveFormula(n));
    }

    private static long SolveRecursively(int n)
    {
        if (n < 0 || n % 2 == 1)
        {
            return 0;
        }

        if (n == 0)
        {
            return 1;
        }

        if (memo[n] > 0)
        {
            return memo[n];
        }

        long sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += SolveRecursively(i) * SolveRecursively(n - i - 2);
        }

        memo[n] = sum;
        return sum;
    }

    private static long SolveIteratively(int n)
    {
        var dp = new long[n + 1];
        dp[0] = 1;
        for (int i = 2; i <= n; i+=2)
        {
            for (int j = 0; j <= i - 2; j += 2)
            {
                dp[i] += dp[j] * dp[i - j - 2];
            }
        }

        return dp[n];
    }

    private static long SolveFormula(int n)
    {
        if (n == 2)
        {
            return 1;
        }
        return n*(n - 1) / 6;
    }
}