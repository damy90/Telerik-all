using System;
using System.Threading;

class Program
{
    static void Main()
    {
        /*int position = 0, width=60;
        while(true)
        {
            //Console.Clear();
            
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                if (pressedKey.Key == ConsoleKey.RightArrow)
                    position+=1;
                if (pressedKey.Key == ConsoleKey.LeftArrow && position>0)
                    position -= 1;
            }
            for (int i = 0; i <= position; i++)
                Console.Write(" ");
            Console.Write("(0)");
            for (int i = position+2; i < width; i++)
                Console.Write(" ");
            Console.Write("\r");
            Thread.Sleep(10);
        }*/
        //random screen
        
        Random random = new Random();
        int w = 40, h = 6;
        char[][] playfield = new char[h][];
        char[] rocks = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
        //for (int i = 0; i < h; i++)
        //{
        //    playfield[i] = new char[w];
        //    for (int j = 0; j < w; j++)
        //        playfield[i][j] = ' ';
        //}
        int top = 0;
        while (true)
        {
            //for (int row = 0; row < h; row++)
            //{
                playfield[0] = new char[w];
                for (int col = 0; col < w; col++)
                {
                    if (random.Next(0, 50) == 0)
                    {
                        int size = random.Next(1, 4);
                        int stone = random.Next(0, rocks.Length);
                        for (int k = 0; k < size && col < w; k++, col++)
                            playfield[0][col] = rocks[stone];
                    }
                    else
                        playfield[0][col] = ' ';

                }

            //}

                Console.SetCursorPosition(0, 0);
                for (int j = 0, n = top; j < h; j++, n = (n == h-1 ? 0 : n + 1))
                    Console.WriteLine(playfield[n]);
                top = (top == 0) ? h-1 : top - 1;
        }
    }
}
//