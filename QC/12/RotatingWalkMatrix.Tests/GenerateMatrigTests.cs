namespace RotatingWalkMatrix.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class WalkMatrixTests
    {
        [TestMethod]
        [Timeout(1000)]
        public void Size4Matrix()
        {
            int n = 4;
            int[,] expected =
                {
                    { 1,  10,  11,  12 },
                    { 9,   2,  15,  13 },
                    { 8,  16,   3,  14 },
                    { 7,   6,   5,   4 }
                };
            var result = new WalkMatrix(n);
            Assert.IsTrue(this.CompareMatrix(expected, result.Matrix));
        }

        [TestMethod]
        [Timeout(1000)]
        public void Size1Matrix()
        {
            int n = 1;
            int[,] expected = { { 1 } };
            var result = new WalkMatrix(n);
            Assert.IsTrue(this.CompareMatrix(expected, result.Matrix));
        }

        [TestMethod]
        [Timeout(1000)]
        public void Size6Matrix()
        {
            int n = 6;
            int[,] expected =
                {
                    { 1,  16,  17,  18,  19,  20 },
                    { 15,  2,  27,  28,  29,  21 },
                    { 14, 31,   3,  26,  30,  22 },
                    { 13, 36,  32,   4,  25,  23 },
                    { 12, 35,  34,  33,   5,  24 },
                    { 11, 10,   9,   8,   7,   6 }
                };
            var result = new WalkMatrix(n);
            Assert.IsTrue(this.CompareMatrix(expected, result.Matrix));
        }

        [TestMethod]
        [Timeout(1000)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Size0MatrixShouldThrow()
        {
            int n = 0;
            var result = new WalkMatrix(n);
        }

        [TestMethod]
        [Timeout(1000)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Size101MatrixShouldThrow()
        {
            int n = 101;
            var result = new WalkMatrix(n);
        }

        [TestMethod]
        [Timeout(1000)]
        public void Size100MatrixShouldNotThrow()
        {
            int n = 100;
            var result = new WalkMatrix(n);
        }

        private bool CompareMatrix(int[,] m1, int[,] m2)
        {
            long rows1 = m1.GetLongLength(0);
            long rows2 = m2.GetLongLength(0);
            long cols1 = m1.GetLongLength(1);
            long cols2 = m2.GetLongLength(1);

            if (rows1 != rows2 || cols1 != cols2)
            {
                return false;
            }

            for (int i = 0; i < m1.GetLongLength(0); i++)
            {
                for (int j = 0; j < m1.GetLongLength(1); j++)
                {
                    if (m1[i, j] != m2[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
