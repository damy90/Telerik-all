using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        long number=0;
        for (int i = 0; i < N; i++)
        {
            number ^= long.Parse(Console.ReadLine());
        }
        Console.WriteLine(number);
    }
}
