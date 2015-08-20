using System;


class FractionsSum
{
    static void Main()
    {
        Console.Title = "The sum of 1+1/2-1/3+1/4-1/5...";
        decimal sum=1;

        for (int denominator = 2, sign = 1; (1m / denominator) >= 0.0001m; denominator++)
        {
            sum = sum + sign*(1m / denominator);
            sign = sign *(-1);
        }
        Console.WriteLine("sum = {0:0.000}", sum);
    }
}
