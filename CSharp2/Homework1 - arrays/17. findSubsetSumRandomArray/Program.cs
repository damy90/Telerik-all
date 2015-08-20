using System;

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.
class Program
{
    static void Main()
    {
        int S = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] number = new int[N];
        string expression;
        bool subsetExists = false;

        for (uint i = 0; i < N; i++)
            number[i] = int.Parse(Console.ReadLine());

        for (int variants = 1; variants < (1 << N); variants++)
        {
            expression = "";
            int sum = 0;
            for (int i = 0; (i < N); i++)
            {
                if (((variants & (1 << i)) != 0))
                {
                    sum += number[i];
                    expression += "("+number[i]+")" + " +";
                }
            }
            int count = 0;
            int accum = variants;
            while (accum > 0)
            {
                accum &= (accum - 1);
                count++;
            }
            if (sum == S && (count <= K))
            {
                expression = expression.Remove(expression.Length - 1);
                Console.WriteLine("{0} = {1}", expression, S);
                subsetExists = true;
                break;
            }
        }
        if (!subsetExists)
            Console.WriteLine("The subset does not exist");
    }
}