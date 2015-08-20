using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int countMax = 0;
        int[] count = new int[N];
        for (int i=0;i<N;i++)
        {
            int vote = int.Parse(Console.ReadLine());
            count[vote] += 1;
            if (count[vote] > countMax)
                countMax = count[vote];
        }

        for (int i=0;i<N;i++)
            if (count[i]==countMax)
            {
                Console.WriteLine(i+1);
                break;
            }
    }
}
