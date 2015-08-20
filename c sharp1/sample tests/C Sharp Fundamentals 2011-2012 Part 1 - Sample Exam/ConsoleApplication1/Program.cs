using System;

class Program
{
    static void Main()
    {
        long S = long.Parse(Console.ReadLine());//sum
        int N = int.Parse(Console.ReadLine());//number count
        //int K = int.Parse(Console.ReadLine());
        long[] number = new long[N];
        int count = 0;

        for (uint i = 0; i < N; i++)
            number[i] = long.Parse(Console.ReadLine());

        for (int variants = 1; variants < (1<<N); variants++)
        {
            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                if ((variants & (1 << i)) != 0)
                {
                    sum += number[i];
                }
            }
            
            if (sum == S)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}
