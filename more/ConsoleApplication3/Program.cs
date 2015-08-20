using System;
using System.Threading;

class Program
{
    static void Main()
    {
        //initialize
        Random random = new Random();
        int width = 40, heigth = 20, pos = 30, row = 0, waitTime = 200, score=0;
        char[][] playfield = new char[heigth][];
        char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        for (int i = 0; i < heigth; i++)
        {
            playfield[i] = new char[width];
            for (int j = 0; j < width; j++)
                playfield[i][j] = ' ';
        }
        while (true)
        {
            //read keyboard buffer
            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (!Console.KeyAvailable)
                {
                    if (pressedKey.Key == ConsoleKey.RightArrow && pos < width - 4)
                        pos += 1;
                    if (pressedKey.Key == ConsoleKey.LeftArrow && pos > 0)
                        pos -= 1;
                }
            }
            if (row == 0 && waitTime > 10)
                waitTime--;//faster speed for increasing difficulty
            score++;
            int btmRow = (row == heigth - 1) ? 0 : row + 1;
            //generate the new line
            for (int col = 0; col < width; col++)
            {
                if (random.Next(0, 200) == 0)
                {
                    int size = random.Next(1, 4);
                    int stone = random.Next(0, rocks.Length);
                    for (int k = 0; k < size && col < width; k++, col++)
                        playfield[row][col] = rocks[stone];
                }
                else
                    playfield[row][col] = ' ';  
            }
            //collision detection
            if (playfield[btmRow][pos] != ' ' || playfield[btmRow][pos + 1] != ' ' || playfield[btmRow][pos + 2] != ' ')
                break;
            //draw player
            playfield[btmRow][pos] = '(';
            playfield[btmRow][pos + 1] = '0';
            playfield[btmRow][pos + 2] = ')';           
            Console.SetCursorPosition(0, 0);
            //draw scene
            for (int j = 0, n = row; j < heigth; j++, n = (n == 0 ? heigth - 1 : n - 1))
                Console.WriteLine(playfield[n]);
            row = btmRow;
            Console.WriteLine("score: {0}",score);      
            Thread.Sleep(waitTime);
        }
        Console.WriteLine("Game over!!!\nPress any key to continue");
        Console.ReadKey();
    }
}