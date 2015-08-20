using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int countMax = 0;
        int[] count = new int[10];
        for (int i = 0; i < N; i++)
        {
            int vote = int.Parse(Console.ReadLine());
            count[vote-1] += 1;
            if (count[vote-1] > countMax)
                countMax = count[vote-1];
        }

        Console.WriteLine(Array.IndexOf(count, countMax) +1);
        //for (int i = 0; i < 10; i++)
        //    if (count[i] == countMax)
        //    {
        //        Console.WriteLine(i+1);
        //        break;
        //    }
    }
}
