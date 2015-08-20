using System;

class Sum0
{
    //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
    //Assume that repeating the same subset several times is not a problem.
    static void Main()
    {
        Console.Title = "Find numbers whose sum is 0";

        int[] numbers = new int[5];
        int sum = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Please enter number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
            sum = sum + numbers[i];
        }
        //all numbers
        if (sum == 0)
            Console.WriteLine("Total sum is 0");
        // 4 numbers
        for (int i = 0; i < 5; i++)
        {
            if (sum - numbers[i] == 0)
            {
                bool first = true;
                for (int j = 0; j < 5; j++)
                    if (j != i)
                    {
                        Console.Write("{1}{0}", numbers[j], (numbers[j] >= 0 && !first) ? "+" : "");
                        first = false;
                    }
                Console.WriteLine("=0");
            }
        }

        for (int i = 0; i < 4; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                int sum2 = numbers[i] + numbers[j];
                //2 numbers
                if (sum2 == 0)
                    Console.WriteLine("{0}{2}{1}=0", numbers[i], numbers[j], numbers[j] > 0 ? "+" : "");
                //3 numbers
                if (sum - sum2 == 0)
                {
                    bool first = true;
                    for (int k = 0; (k < 5); k++)//??
                        if (k != i && k != j)
                        {
                            Console.Write("{1}{0}", numbers[k], (numbers[k] >= 0 && !first) ? "+" : "");
                            first = false;
                        }
                            
                    Console.WriteLine("=0");
                }
            }
        }
    }
}