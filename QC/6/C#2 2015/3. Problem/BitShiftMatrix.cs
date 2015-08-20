using System;
using System.IO;
using System.Linq;
using System.Numerics;

public class BitShiftMatrix
{
    public static void Main()
    {
        // auto test
        ////StreamReader reader=new StreamReader(new FileStream("../../input.txt", FileMode.Open));
        ////Console.SetIn(reader);

        int heigth = int.Parse(Console.ReadLine());
        int width = int.Parse(Console.ReadLine());
        int movesCount = int.Parse(Console.ReadLine());
        int[] moves = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

        // auto test
        ////reader.Close();

        BigInteger[][] matrix = GenerateGameFieldMatrix(heigth, width);
        BigInteger sumVisited = CalculateScore(heigth, width, moves, matrix);

        Console.WriteLine(sumVisited);
    }

    private static BigInteger CalculateScore(int heigth, int width, int[] moves, BigInteger[][] matrix)
    {
        BigInteger sumVisited = 0;
        int coeficient = Math.Max(heigth, width);
        int posX = 0;
        int posY = heigth - 1;
        for (int i = 0; i < moves.GetLength(0); i++)
        {
            int moveToX = moves[i] % coeficient;
            int moveToY = moves[i] / coeficient;

            int walkXFrom = Math.Min(moveToX, posX);
            int walkXTo = Math.Max(moveToX, posX);
            for (int j = walkXFrom; j <= walkXTo; j++)
            {
                sumVisited += matrix[posY][j];
                matrix[posY][j] = 0;
            }

            posX = moveToX;

            int walkYFrom = Math.Min(moveToY, posY);
            int walkYTo = Math.Max(moveToY, posY);
            for (int j = walkYFrom; j <= walkYTo; j++)
            {
                sumVisited += matrix[j][posX];
                matrix[j][posX] = 0;
            }

            posY = moveToY;
        }

        return sumVisited;
    }

    private static BigInteger[][] GenerateGameFieldMatrix(int heigth, int width)
    {
        var matrix = new BigInteger[heigth][];
        for (int i = 0; i < heigth; i++)
        {
            matrix[i] = new BigInteger[width];
            for (int j = 0; j < width; j++)
            {
                matrix[i][j] = (BigInteger)1 << (i + j);
            }
        }

        matrix = matrix.OrderByDescending(m => m[0])
            .ToArray();
        return matrix;
    }
}