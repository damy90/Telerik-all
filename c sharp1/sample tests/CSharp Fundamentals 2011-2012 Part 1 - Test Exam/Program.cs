using System;

//(N*N+1/M*P+1337)/(N-128.523123123*P)+sin(M mod 180)
class Program
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double M = double.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        //double result = (double)((N * N + 1 / (M * P) + 1337) / (N - 128.523123123 * P) + Math.Sin(Math.Floor(M % 180)));
        Console.WriteLine("{0:F6}",(double)((N * N + 1 / (M * P) + 1337) / (N - 128.523123123 * P) + Math.Sin((int)(M % 180))));
    }
}
