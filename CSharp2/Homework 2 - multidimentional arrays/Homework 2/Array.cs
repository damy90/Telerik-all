using System;
//Write a program that fills and prints a matrix of size (n, n)

class Array
{
    static void Main()
    {
        int size = 4, number = 1;
        int[,] matrix = new int[size, size];

        Console.WriteLine("\na)");
        for (int row = 0; row < size; row++)
            for (int col = 0; col < size; col++, number++)
                matrix[row, col] = number;

        Print(matrix);

        Console.WriteLine("\nb)");
        number = 1;
        for (int row = 0, direction = 1, col = 0; row < size; row++)
        {
            //direction can be 1 and -1. if direction=1 (>0) the condition is col < size and col is incremented on each step. Otherwise col is >= 0 and is decremented on each step.
            for (; (direction > 0) ? (col < size) : (col >= 0); col += direction, number++)
                matrix[row, col] = number;
            direction=-direction;//reverses the direction in which the array is filled after every row
            col += direction;//After the cycle breaks the index is always outside the array. For the next cycle to continue from the same column on the next row 1 must be added or subtracted.
        }

        Print(matrix);

        Console.WriteLine("\nc)");
        number = 1;
        //calculate the values below (and including) the diagonal(starting at 0,0)
        for (int cycle = 0; cycle < size; cycle++)
            for (int col = 0, row = size - 1 - cycle; row < size; row++, col++, number++)
                matrix[col, row] = number;
        //calculate the values above the diagonal
        for (int cycle = 0; cycle < size - 1; cycle++)
            for (int col = 1 + cycle, row = 0; col < size; row++, col++, number++)
                matrix[col, row] = number;

        Print(matrix);

        Console.WriteLine("\nd)*");
        number = 1;
        for (int cycle = 0, col, row; cycle < size / 2; cycle++)
        {
            for (col = cycle, row = cycle; row < size - cycle - 1; row++, number++)     //left side
                matrix[col, row] = number;
            //each cycle continiues from the last position of the previous cycle accept for the 1-st
            for (; col < size - cycle - 1; col++, number++)                             //bottom side
                matrix[col, row] = number;
            for (; row > cycle; row--, number++)                                        //right side
                matrix[col, row] = number;
            for (; col > cycle; col--, number++)                                        //top side
                matrix[col, row] = number;
        }
        if (size%2!=0)
            matrix[size / 2, size / 2] = number;                                        //center (if the size of the array is an odd number)

        Print(matrix);
    }

    //Method for printing the results
    static void Print(int[,] matrix)
    {
        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            Console.WriteLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
                Console.Write("{0}\t", matrix[row, col]);
        }
        Console.WriteLine();
    }
}
