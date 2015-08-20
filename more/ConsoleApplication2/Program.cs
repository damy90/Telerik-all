using System;

class Program
{
    static void Main()
    {
        int[] playfield = { 1, 2, 3, 4 };
        int top = 0;
        while (true)
        {
            Console.SetCursorPosition(0, 0);
            for (int j = 0, n=top; j < 4; j++, n=(n==3? 0 : n+1))
                Console.WriteLine(playfield[n]);
            top = (top == 0) ? 3 : top - 1;
        }
    }
}