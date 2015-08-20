using System;
using System.Text;

public class WalkMatrix
{
    private static int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };

    private static int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

    private int size;

    public WalkMatrix(int size)
    {
        this.Size = size;
        this.Matrix = this.GenerateMatrix(this.size);
    }

    public int Size
    {
        get
        {
            return this.size;
        }

        private set
        {
            if (value <= 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid number!");
            }

            this.size = value;
        }
    }

    public int[,] Matrix { get; private set; }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder((this.size * this.size) + this.size);
        for (int i = 0; i < this.size; i++)
        {
            for (int j = 0; j < this.size; j++)
            {
                result.AppendFormat("{0,4}", this.Matrix[i, j]);
            }

            result.AppendLine();
        }

        return result.ToString();
    }

    private void ChangeDirection(ref int dx, ref int dy)
    {
        int cd = 0;
        for (int i = 0; i < 8; i++)
        {
            if (directionX[i] == dx && directionY[i] == dy)
            {
                cd = i;
                break;
            }
        }

        if (cd == 7)
        {
            cd = -1;
        }

        dx = directionX[cd + 1];
        dy = directionY[cd + 1];
    }

    private bool EmptyNeighbourCheck(int[,] arr, int x, int y)
    {
        for (int i = 0; i < 8; i++)
        {
            if (x + directionX[i] >= arr.GetLength(0) || x + directionX[i] < 0)
            {
                continue;
            }

            if (y + directionY[i] >= arr.GetLength(0) || y + directionY[i] < 0)
            {
                continue;
            }

            if (arr[x + directionX[i], y + directionY[i]] == 0)
            {
                return true;
            }
        }

        return false;
    }

    private void FindEmptyCell(int[,] arr, out int x, out int y)
    {
        x = -1;
        y = -1;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                if (arr[i, j] == 0)
                {
                    x = i;
                    y = j;
                    return;
                }
            }
        }
    }

    private int[,] GenerateMatrix(int matrixSize)
    {
        int[,] matrix = new int[matrixSize, matrixSize];
        int step = 1,
            row = 0,
            col = 0;

        while (row != -1 && col != -1)
        {
            int dirY = 1,
                dirX = 1;

            while (true)
            {
                matrix[row, col] = step;
                if (!this.EmptyNeighbourCheck(matrix, row, col))
                {
                    step++;
                    break;
                }

                while (this.IsOutOfBounds(row, dirY, col, dirX) || matrix[row + dirY, col + dirX] != 0)
                {
                    this.ChangeDirection(ref dirY, ref dirX);
                }

                row += dirY;
                col += dirX;
                step++;
            }

            this.FindEmptyCell(matrix, out row, out col);
        }

        return matrix;
    }

    private bool IsOutOfBounds(int row, int dirY, int col, int dirX)
    {
        if (row + dirY >= this.size || row + dirY < 0 || col + dirX >= this.size || col + dirX < 0)
        {
            return true;
        }

        return false;
    }
}
