using System;

class Program
{
    private static int n = 0;
    private static char[,] cubeArray;
    static void Main()
    {
        //todo solve overriding array elements
        n = int.Parse(Console.ReadLine());
        cubeArray = new char[2 * n, 2 * n];

        for (int row = 0; row < 2 * n; row++)
        {
            for (int col = 0; col < 2 * n; col++)
            {
                cubeArray[row, col]=' ';
            }
        }

        SetSideHorysontal(0, 0);
        SetSideHorysontal(n - 1, 0);
        SetSideVertical(0, 0);
        SetSideVertical(0, n - 1);

        for (int i = 1; i < n - 1; i++)
        {
            SetSideHorysontalSpecial(n - 1 + i, i);
            SetSideVerticalSpecial(i, n - 1 + i);
        }

        SetSideHorysontal(2 * n - 2, n - 1);
        SetSideVertical(n - 1, 2 * n - 2);

        for (int row = 0; row < 2 * n; row++)
        {
            for (int col = 0; col < 2 * n; col++)
            {
                Console.Write(cubeArray[row, col]);
            }
            if (row != 2 * n - 1)
            {
                Console.WriteLine();
            }
        }
    }

    private static void SetSideHorysontal(int posRow, int posCol)
    {
        for (int i = 0; i < n; i++)
        {
            cubeArray[posRow, posCol + i] = ':';
        }
    }

    private static void SetSideVertical(int posRow, int posCol)
    {
        for (int i = 0; i < n; i++)
        {
            cubeArray[posRow + i, posCol] = ':';
        }
    }

    private static void SetSideHorysontalSpecial(int posRow, int posCol)
    {
        cubeArray[posRow, posCol] = ':';
        cubeArray[posRow, posCol + n - 1] = ':';
        for (int i = 1; i < n - 1; i++)
        {
            cubeArray[posRow, posCol + i] = '-';
        }
    }

    private static void SetSideVerticalSpecial(int posRow, int posCol)
    {
        cubeArray[posRow, posCol] = ':';
        cubeArray[posRow + n - 1, posCol] = ':';
        for (int i = 1; i < n - 1; i++)
        {
            cubeArray[posRow + i, posCol] = '|';
        }
    }
}
