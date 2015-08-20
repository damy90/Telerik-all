namespace Matrix
{
    using System;
    public class MatrixClass<T> where T : IComparable
    {
        T[,] matrix;

        public MatrixClass(int rows, int cols)
        {
            this.Matrix = new T[rows, cols];
        }
        public T[,] Matrix
        {
            get
            {
                return this.matrix;
            }
            set
            {
                this.matrix = value;
            }
        }

        public T this[int rowIndex, int colIndex]
        {

            get
            {
                if (rowIndex < 0 || rowIndex > matrix.GetLength(0) || colIndex < 0 || colIndex > matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Out of range");
                }
                else
                {
                    return this.matrix[rowIndex, colIndex];
                }
            }
            set
            {
                if (rowIndex < 0 || rowIndex > matrix.GetLength(0) || colIndex < 0 || colIndex > matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException("Out of range");
                }
                else
                {
                    this.matrix[rowIndex, colIndex] = value;
                }
            }
        }

        public static MatrixClass<T> operator +(MatrixClass<T> matrix1, MatrixClass<T> matrix2)
        {
            if (matrix1.matrix.GetLength(0) != matrix1.matrix.GetLength(0) ||
                matrix1.matrix.GetLength(1) != matrix1.matrix.GetLength(1))
            {
                throw new Exception("Impossible operation");
            }
            MatrixClass<T> newMatrix = new MatrixClass<T>(matrix1.matrix.GetLength(0), matrix1.matrix.GetLength(0));
            for (int i = 0; i < matrix1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }
            return newMatrix;
        }

        public static MatrixClass<T> operator -(MatrixClass<T> matrix1, MatrixClass<T> matrix2)
        {
            if (matrix1.matrix.GetLength(0) != matrix1.matrix.GetLength(0) ||
                matrix1.matrix.GetLength(1) != matrix1.matrix.GetLength(1))
            {
                throw new Exception("Impossible operation");
            }
            MatrixClass<T> newMatrix = new MatrixClass<T>(matrix1.matrix.GetLength(0), matrix1.matrix.GetLength(0));
            for (int i = 0; i < matrix1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }
            return newMatrix;
        }

        public static MatrixClass<T> operator *(MatrixClass<T> matrix1, MatrixClass<T> matrix2)
        {
            MatrixClass<T> newMatrix = new MatrixClass<T>(matrix1.matrix.GetLength(0), matrix1.matrix.GetLength(1));
            if (matrix1.matrix.GetLength(1) == matrix2.matrix.GetLength(0))
            {
                
                for (int i = 0; i < newMatrix.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < newMatrix.matrix.GetLength(1); j++)
                    {
                        newMatrix[i, j] = (dynamic)0;
                        for (int k = 0; k < matrix1.matrix.GetLength(1); k++)
                        {                            
                            newMatrix[i, j] = newMatrix[i, j] + (dynamic)matrix1[i, k] * matrix2[k, j];
                        }
                    }
                }
            }
            else
            {
                throw new Exception("Impossible operation");
            }

            return newMatrix;
        }

        public static bool operator true(MatrixClass<T> matrix1)
        {
            for (int i = 0; i < matrix1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.matrix.GetLength(1); j++)
                {
                    if (matrix1[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator false(MatrixClass<T> matrix)
        {
            for (int i = 0; i < matrix.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return true;
        }
    }
}

