namespace Matix.Tests
{
    using System;
    using Matrix;
    class MatrixTest
    {
        static void Main()
        {
            Matrix<int> matrixOne = new Matrix<int>(2, 2);
            Matrix<int> matrixTwo = new Matrix<int>(2, 2);
            int index = 1;
            for (int row = 0; row < matrixOne.Rows; row++)
            {
                for (int col = 0; col < matrixOne.Cols; col++)
                {
                    matrixOne[row, col] = index;
                    matrixTwo[row, col] = index;
                    index++;
                }
            }
            var result = matrixTwo + matrixOne;
            var resultMinus = matrixOne - matrixTwo;
            var resultMulti = matrixOne * matrixTwo;
            bool res = result ? true:false ;
            bool resOne = resultMinus ? true : false;
        }
    }
}
