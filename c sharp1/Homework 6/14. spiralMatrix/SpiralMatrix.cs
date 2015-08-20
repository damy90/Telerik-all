using System;

class SpiralMatrix
{
    //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral.
    static void Main()
    {
        Console.Title = "Spiral matrix";

        uint size, number = 1;
        Console.Write("Please enter size of the matrix: ");
        while (true)
        {
            if (uint.TryParse(Console.ReadLine(), out size) && size <= 20)
                break;
            Console.Write("Please enter a positive integer number less than 20: ");
        }

        uint[,] matrix = new uint[size, size];
        for (uint cycle = 0, posX, posY; cycle < size / 2; cycle++)
        {
            for (posX = cycle, posY = cycle; posX < size - cycle - 1; posX++, number++)     //top
                matrix[posX, posY] = number;
            for (; posY < size - cycle - 1; posY++, number++)                               //left
                matrix[posX, posY] = number;
            for (; posX > cycle; posX--, number ++)                                         //bottom
                matrix[posX, posY] = number;
            for (; posY > cycle; posY--, number++)                                          //right
                matrix[posX, posY] = number;
        }
        if (size%2!=0)
            matrix[size / 2, size / 2] = number;

        for (uint j = 0; j < size; j++)
        {
            Console.WriteLine();
            for (uint i = 0; i < size; i++)
                Console.Write("{0}\t",matrix[i, j]);
        }

        Console.WriteLine();
    }
}
