using System;

class Program
{
    static void Main()
    {
        long S = long.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        //int K = int.Parse(Console.ReadLine());
        int countSubset = 0;
        long[] number = new long[N];
        string expression;

        for (uint i = 0; i < N; i++)
            number[i] = long.Parse(Console.ReadLine());

        for (int variants = 1; variants < (1 << N); variants++)
        {
            expression = "";
            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                
                if (((variants & (1 << i)) != 0))
                {
                    sum += number[i];
                    expression += "+" + number[i];
                }
            }
            if (sum == S)
            {
                countSubset++;
                Console.WriteLine(expression);
            }
        }
        Console.WriteLine(countSubset);
    }
}