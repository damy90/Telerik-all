using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char[][] screen = new char[2*N - 1][];
        //set matrix
        for (int i = 0; i < 2 * N - 1; i++)
        {
            screen[i] = new char[N];
            for (int j = 0; j < N; j++)
                screen[i][j] = '.';
        }

        for (int i = 0; i < N; i++)
        {
            screen[i][i] = '*';
            screen[2 * N - 2 - i][i] = '*';
        }

        for (int i = 0; i < 2*N - 1; i++)
            Console.WriteLine(screen[i]);
    }
}
