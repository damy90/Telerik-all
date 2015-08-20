using System;

class Program
{
    static void Main(string[] args)
    {
        int size = 4, number = 1;
        int[,] matrix = new int[size, size];

        for (int cycle = 0; cycle < size; cycle++)
            for (int col = 0, row = size - 1 - cycle; row < size; row++, col++, number++)
                matrix[col, row] = number;
        for (int cycle = 0; cycle < size-1; cycle++)
            for (int col=1+cycle, row=0; col<size; row++, col++, number++)
                matrix[col, row] = number;

        for (int col = 0; col < size; col++)
        {
            Console.WriteLine();
            for (int row = 0; row < size; row++)
                Console.Write("{0}\t", matrix[row, col]);
        }
        Console.WriteLine();
    }
}
