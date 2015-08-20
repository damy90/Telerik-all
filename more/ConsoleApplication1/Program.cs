using System;

class Program
{
    static void Main()
    {
        int[] playfield = {1, 2, 3, 4};

        while (true)
        {
            for (int j = 1; j <= 4; j++)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 3; i >= 0; i--)
                {
                    Console.WriteLine(playfield[i]);
                }
            }
            for (int i = 0; i < 3; i++)
                playfield[i] = playfield[i + 1];
            playfield[3] = 5;
        }
    }
}