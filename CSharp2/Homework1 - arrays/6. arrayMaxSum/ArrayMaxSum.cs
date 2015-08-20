using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
            int.TryParse(Console.ReadLine(), out array[i]);

        //hardcoded test
        //array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        //N = array.Length;
        //K = 3;

        Array.Sort<int>(array);
        for (int i = N - K; i < N; i++)
            Console.Write("{0} ", array[i]);
        Console.WriteLine();
    }
}
