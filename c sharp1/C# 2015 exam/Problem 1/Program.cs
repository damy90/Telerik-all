using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        int paperPackQuantity = 400;

        double result = p * n * s / paperPackQuantity;
        Console.WriteLine("{0:0.000}", result);
    }
}