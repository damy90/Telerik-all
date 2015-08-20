namespace Matrix
{
    using System;
    //using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;
    //using System.Threading.Tasks;
    //using System.Numerics;
    
    //Problem 8. Matrix
    //Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).

    public class Matrix<T> where T: struct

    {
        private T[,] matrix;
        private int rows;
        private int cols;
        
        public  Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[Rows, Cols];
        }
        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if(this.rows < 0)
                {
                    throw new ArgumentOutOfRangeException("Rows must be positive.");
                }
                this.rows = value;
            }
        }
        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (this.cols < 0)
                {
                    throw new ArgumentOutOfRangeException("Rows must be positive.");    
                }
                this.cols = value;
            }
        }
    //    Problem 9. Matrix indexer
    //Implement an indexer this[row, col] to access the inner matrix cells.
        public T this[int row, int col]
        {
            get
            {
                return matrix[row,col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }
    //    Problem 10. Matrix operations
    //Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
    //Throw an exception when the operation cannot be performed.
    //Implement the true operator (check for non-zero elements).
        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.matrix.GetLength(0)!=matrixTwo.matrix.GetLength(0)||matrixOne.matrix.GetLength(1)!=matrixTwo.matrix.GetLength(1))
            {
                throw new ArgumentException("Sum can not be applied for diff of size matrixes.");
            }
            Matrix<T> sumMatrix = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixOne.matrix.GetLength(1));
            for (int row = 0; row < matrixOne.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.matrix.GetLength(1); col++)
                {
                    sumMatrix[row, col] = (dynamic)matrixOne.matrix[row, col] + matrixTwo.matrix[row, col];
                }
            }
            
            return sumMatrix;    
        }
        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.matrix.GetLength(0) != matrixTwo.matrix.GetLength(0) || matrixOne.matrix.GetLength(1) != matrixTwo.matrix.GetLength(1))
            {
                throw new ArgumentException("Subtraction can not be applied for diff of size matrixes.");
            }
            Matrix<T> subtractMatrix = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixOne.matrix.GetLength(1));
            for (int row = 0; row < matrixOne.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.matrix.GetLength(1); col++)
                {
                    subtractMatrix[row, col] = (dynamic)matrixOne.matrix[row, col] - matrixTwo.matrix[row, col]; ;
                }
            }
            return subtractMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {

            if (matrixOne.matrix.GetLength(0) != matrixTwo.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrixes' columns and rows should be equal");
            }
            Matrix<T> multiplyMatrix = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixTwo.matrix.GetLength(1));
            for (int row = 0; row < matrixOne.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.matrix.GetLength(1); col++)
                {
                    multiplyMatrix[row, col] = (dynamic)matrixOne[row, col] * matrixTwo[col, row];
                }
            }
            return multiplyMatrix;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            bool noZero = true;
            for (int row = 0; row < matrix.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.matrix.GetLength(1); col++)
                {
                    if ((dynamic)matrix[row,col] == 0)
                    {
                        noZero = false;
                    }
                }
            }
            return noZero;
        }
        public static bool operator false(Matrix<T> matrix)
        {
            bool noZero = true;
            for (int row = 0; row < matrix.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.matrix.GetLength(1); col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        noZero = false;
                    }
                }
            }
            return noZero;
        }
    }
}
