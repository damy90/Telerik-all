using System;
using System.Linq;

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class MatrixMaxSum
{
    static void Main()
    {
        Console.WriteLine("Please enter matrix width");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter matrix heigth");
        int heigth = int.Parse(Console.ReadLine());

        int[,] matrix = new int[heigth, width];

        Console.WriteLine("Please enter matrix rows (comma separated)");
        for (int i = 0; i < heigth; i++)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            Array.Resize(ref numbers, width);

            for (int j = 0; j < width; j++)
            {
                matrix[i, j] = numbers[j];
            }
        }

        //hardcoded test
        //matrix = new int[,]{
        //    {7, 1, 3, 3, 2, 1},
        //    {1, 3, 9, 8, 5, 3},
        //    {3, 2, 7, 9, 9, 2},
        //    {4, 6, 7, 9, 9, 1} 
        //};

        string result = "";
        int bestSum = int.MinValue, rectSize = 3;
        //change starting element
        for (int row = 0; row <= matrix.GetLength(0) - rectSize; row++)
            for (int col = 0; col <= matrix.GetLength(1) - rectSize; col++)
            {
                string elements = "";
                int sum = 0;
                //calculate rectangle sum create a string with all the elements
                for (int i = 0; i < rectSize; i++)
                {
                    elements += "\n";//next row in the rectangle to be summed
                    for (int j = 0; j < rectSize; j++)
                    {
                        sum += matrix[row + i, col + j];
                        elements += matrix[row + i, col + j] + "\t";
                    }
                }
                //check if this is the bigest sum so far and save the elements if true
                if (sum > bestSum)
                {
                    bestSum = sum;
                    result = elements;
                }
            }
        Console.WriteLine(result);
    }
}
