using System;

//8. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
//9. Implement an indexer this[row, col] to access the inner matrix cells.
//10. Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//Throw an exception when the operation cannot be performed.
//Implement the true operator (check for non-zero elements).

class Matrix<T> where T : IComparable, new()
{
    private readonly T[,] elements;

    public Matrix(T[,] elements)
    {
        this.elements = elements;
    }

    public Matrix(int cols, int rows)
    {
        this.elements = new T[cols, rows];
    }

    public T this[int row, int col]
    {
        get
        {
            if (row >= elements.GetLength(0) || row < 0)
            {
                throw new IndexOutOfRangeException("Matrix row out of range!");
            }

            if (col >= elements.GetLength(1) || col < 0)
            {
                throw new IndexOutOfRangeException("Matrix column out of range!");
            }

            T result = elements[row, col];
            return result;
        }

        set
        {
            this.elements[row, col] = value;
        }
    }

    public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        MatrixOppreatorArgumentsCheck(matrix1, matrix2);

        Matrix<T> result = new Matrix<T>(matrix1.elements);

        for (int i = 0; i < result.elements.GetLength(0); i++)
        {
            for (int j = 0; j < result.elements.GetLength(1); j++)
            {
                result[i, j] += (dynamic)matrix2[i, j];
            }
        }

        return result;
    }

    private static void MatrixOppreatorArgumentsCheck(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.elements.GetLength(0) != matrix2.elements.GetLength(0))
        {
            throw new ArgumentException("Matrices must have the same number of rows");
        }

        if (matrix1.elements.GetLength(1) != matrix2.elements.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same number of columns");
        }
    }

    public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        MatrixOppreatorArgumentsCheck(matrix1, matrix2);

        Matrix<T> result = new Matrix<T>(matrix1.elements);

        for (int i = 0; i < result.elements.GetLength(0); i++)
        {
            for (int j = 0; j < result.elements.GetLength(1); j++)
            {
                result[i, j] *= (dynamic)matrix2[i, j];
            }
        }

        return result;
    }

    public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        MatrixOppreatorArgumentsCheck(matrix1, matrix2);

        Matrix<T> result = new Matrix<T>(matrix1.elements);

        for (int i = 0; i < result.elements.GetLength(0); i++)
        {
            for (int j = 0; j < result.elements.GetLength(1); j++)
            {
                result[i, j] -= (dynamic)matrix2[i, j];
            }
        }

        return result;
    }

    public static bool operator true(Matrix<T> matrix)
    {

        for (int i = 0; i < matrix.elements.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.elements.GetLength(1); j++)
            {
                if (matrix[i, j] == (dynamic)0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static bool operator false(Matrix<T> matrix)
    {
        for (int i = 0; i < matrix.elements.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.elements.GetLength(1); j++)
            {
                if (matrix[i, j] == (dynamic)0)
                {
                    return false;
                }
            }
        }

        return true;
    }
}
