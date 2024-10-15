using Matrix;

namespace TestMatrix
{
    [TestClass]
    public class TestMultiply
    {
        public static void copyMatrixIntoArray(MyMatrix matrix, double[,] arr)
        {
            for (int i = 0; i < matrix.Height; i++)
            {
                for (int j = 0; j < matrix.Width; j++)
                {
                    arr[i, j] = matrix[i, j];
                }
            }
        }

        [TestMethod]
        public void MultiplyEqual()
        {
            double[,] input1 = { {1,0,0,85 }, {0,85,5,0 }, { 0, -1, 85, 2 }, { 85, 0, 4, 85 } };
            double[,] input2 = { { 1, 0, 0, 0 }, { 0, 0, 5, 1 }, { 0, -1, 85, 0 }, { 85, 0, 4, 0 } };

            MyMatrix matrix1 = new(input1);
            MyMatrix matrix2 = new(input2);

            MyMatrix productMatrix = matrix1 * matrix2;

            double[,] actual = new double[productMatrix.Height,productMatrix.Width];

            copyMatrixIntoArray(productMatrix, actual);

            double[,] expected = { {7226, 0, 340, 0},{0, -5, 850, 85},{170, -85, 7228, -1},{7310, -4, 680, 0} };

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyDifferent1()
        {
            double[,] input1 = { { 0, 0, 85, 85 }, { 5, 0, 0, 0 - 1 }, { 2, 85, 0, 4 } };
            double[,] input2 = { { 1, 0, 0 }, { 0, 5, 1 }, { 0, 85, 0 }, { 85, 0, 4 } };

            MyMatrix matrix1 = new(input1);
            MyMatrix matrix2 = new(input2);

            MyMatrix productMatrix = matrix1 * matrix2;

            double[,] actual = new double[productMatrix.Height, productMatrix.Width];

            copyMatrixIntoArray(productMatrix, actual);

            double[,] expected = { { 7225, 7225, 340 }, { -80, 0, -4}, { 342, 425, 101}};

            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultiplyDifferent2()
        {
            double[,] input1 = { { 1, 1, 4, 2, }, { 3, 2, 3, 85 }, { 5, 0, 0, -1 }, { 2, 85, 0, 4 } };
            double[,] input2 = { { 1, 0, 0 }, { 0, 5, 1 }, { 0, 85, 0 }, { 85, 0, 4 } };

            MyMatrix matrix1 = new(input1);
            MyMatrix matrix2 = new(input2);

            MyMatrix productMatrix = matrix1 * matrix2;

            double[,] actual = new double[productMatrix.Height, productMatrix.Width];

            copyMatrixIntoArray(productMatrix, actual);

            double[,] expected = { { 171, 345, 9 }, { 7228, 265, 342 }, { -80, 0, -4 }, {342, 425, 101} };

            CollectionAssert.AreEqual(expected, actual);
        }
        
    }
}