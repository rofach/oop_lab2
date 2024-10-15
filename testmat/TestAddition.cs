using Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMatrix
{
    [TestClass]
    public class TestAddition
    {
        [TestMethod]
        public void AddTestJag()
        {
            double[][] input1 = new double[][]{ new double[]{ 1, 0, 0, 85 }, new double[] { 0, 85, 5, 0 }, new double[] { 0, -1, 85, 2 }, new double[] { 85, 0, 4, 85 } };
            double[,] input2 = { { 1, 0, 0, 0 }, { 0, 0, 5, 1}, { 0, -1, 85, 0}, { 85, 0, 4, 0} };

            MyMatrix matrix1 = new(input1);
            MyMatrix matrix2 = new(input2);

            MyMatrix sumMatrix = matrix1 + matrix2;
            double[,] actual = new double[matrix1.Height, matrix1.Width];
            TestMultiply.copyMatrixIntoArray(sumMatrix, actual);

            double[,] expected = { { 2, 0, 0, 85 }, { 0, 85, 10, 1 }, { 0, -2, 170, 2 }, { 170, 0, 8, 85 } };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest()
        {
            double[,] input1 = new double[,] { { 1, 0, 0, 85 },  { 0, 85, 5, 0 },  { 0, -1, 85, 2 },  { 85, 0, 4, 85 } };
            double[,] input2 = { { 1, 0, 0, 0 }, { 0, 0, 5, 1 }, { 0, -1, 85, 0 }, { 85, 0, 4, 0 } };

            MyMatrix matrix1 = new(input1);
            MyMatrix matrix2 = new(input2);

            MyMatrix sumMatrix = matrix1 + matrix2;
            double[,] actual = new double[matrix1.Height, matrix1.Width];
            TestMultiply.copyMatrixIntoArray(sumMatrix, actual);

            double[,] expected = { { 2, 0, 0, 85 }, { 0, 85, 10, 1 }, { 0, -2, 170, 2 }, { 170, 0, 8, 85 } };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
