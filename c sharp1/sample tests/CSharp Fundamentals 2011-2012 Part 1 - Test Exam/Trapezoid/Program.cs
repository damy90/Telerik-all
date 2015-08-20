using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        char[][] screen = new char[N+1][];
        //set matrix
        for (int i = 0; i < N+1; i++)
        {
            screen[i] = new char[2 * N];
            for (int j = 0; j < 2*N; j++)
                screen[i][j] = '.';
        }
        //top
        for (int i=N; i<2*N; i++)
            screen[0][i] = '*';
        //bottom
        for (int i = 0; i < 2 * N; i++)
            screen[N][i] = '*';
        //reght
        for (int i = 1; i < N; i++)
            screen[i][2*N-1] = '*';
        //diagonal
        for (int i = 1, j=N-1; i<N+1 && j>0; i++, j--)
            screen[i][j] = '*';
        for (int i = 0; i < N + 1; i++)
            Console.WriteLine(screen[i]);
    }
}
