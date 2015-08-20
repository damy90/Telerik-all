using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
            int.TryParse(Console.ReadLine(), out array[i]);

        Array.Sort<int>(array);
        for (int i = K-1; i <N; i++)
            Console.Write("{0} ", array[i]);
        Console.WriteLine();
    }
}
