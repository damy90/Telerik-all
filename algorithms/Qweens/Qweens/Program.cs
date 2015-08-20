using System;

namespace Qweens
{
    class Program
    {
        static readonly int width = 8;
        static readonly int height = 8;
        static readonly int maxQueens = 8;
        static readonly int[,] gameboard = new int[height, width];
        static readonly int[,] results = new int[maxQueens, 2];

        static void Main(string[] args)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    gameboard[i, j] = 0;
                }
            }
                
            RecurseQueens(0);
        }

        static void RecurseQueens(int depth)
        {
            if (depth == maxQueens)
            {
                //print the results
                Console.WriteLine("Queens on positions:");
                for (int i = 0; i < maxQueens; i++)
                {
                    Console.WriteLine("{0} , {1}", results[i, 0], results[i, 1]);
                }

                Console.WriteLine("\nPress any key to see the next variant:");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (gameboard[i, j] == 0)
                    {
                        AddRemoveQueen(i, j, depth, true);
                        RecurseQueens(depth + 1);
                        AddRemoveQueen(i, j, depth, false);
                    }
                }    
            }
        }

        static void AddRemoveQueen(int x, int y, int depth, bool add)
        {
            if (add)
            {
                results[depth, 0] = x;
                results[depth, 1] = y;
            }

            int incr = add ? +1 : -1;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (i == x || j == y || (Math.Abs(i - x) == Math.Abs(j - y)))
                    {
                        gameboard[i, j] += incr;
                    }   
                }  
            } 
        }
    }
}
