using System;
using System.IO;
using System.Linq;

//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
class Program
{
    static void Main(string[] args)
    {
        int[][] matrix={};
        int rectSize = 2;
        int size=0;
        //read matrix from file
        using (StreamReader input = new StreamReader("../../input.txt"))
        {
            size = int.Parse(input.ReadLine());

            matrix = new int[size][];
            for (int i = 0; i < size; i++)
            {
                matrix[i] = input.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            }

                
        }

        //find biggest sum
        string result = "";
        int bestSum = int.MinValue;
        //change starting element
        for (int row = 0; row <= size - rectSize; row++)
            for (int col = 0; col <= size - rectSize; col++)
            {
                string elements = "";
                int sum = 0;
                //calculate rectangle sum create a string with all the elements
                for (int i = 0; i < rectSize; i++)
                {
                    elements += "\n";//next row in the rectangle to be summed
                    for (int j = 0; j < rectSize; j++)
                    {
                        sum += matrix[row + i][col + j];
                        elements += matrix[row + i][col + j] + "\t";
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
        Console.WriteLine(bestSum);

        //write biggest sum
        using (StreamWriter output = new StreamWriter("../../result.txt"))
        {
            output.WriteLine(bestSum);
        }
    }
}
