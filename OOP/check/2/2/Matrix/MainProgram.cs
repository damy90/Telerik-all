namespace Matrix
{
    class MainProgram
    {
        static void Main()
        {
            MatrixClass<int> matrix1 = new MatrixClass<int>(2,2);
            matrix1[0, 0] = 1;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 0;           
            MatrixClass<int> matrix2 = new MatrixClass<int>(2, 2);
            matrix2[0, 0] = 2;
            matrix2[0, 1] = 2;
            matrix2[1, 0] = 2;
            matrix2[1, 1] = 2;
            
            //Problem 10 - without predefening the operaotrs +,-, * the compiler throw an error.
            //You can check this - comment the +,-, * methods at the MatrixClass           
            MatrixClass<int> matrixSum = matrix1 + matrix2;
            MatrixClass<int> matrixSub = matrix1 - matrix2;
            MatrixClass<int> matrixMulti = matrix1 * matrix2;
        }
    }
}
