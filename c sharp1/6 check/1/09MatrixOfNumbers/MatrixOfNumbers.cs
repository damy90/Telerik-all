/*Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.*/

using System;
    class MatrixOfNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool inRange = n >= 1 && n <= 20;
            if (inRange)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int column = 0; column < n; column++)
                    {
                        Console.Write(row + column + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Correct input --> 1 <= n <= 20");
            }
        }
    }