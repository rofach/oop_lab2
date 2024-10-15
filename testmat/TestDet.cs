using Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMatrix
{
    [TestClass]
    public class TestDet
    {
        [TestMethod]
        public void testDet4d()
        {
            double[,] input1 = { { 1, 0, 0, 85 }, { 0, 85, 5, 0 }, { 0, -1, 85, 2 }, { 85, 0, 4, 85 } };
            MyMatrix matrix = new(input1);
            double? expected = matrix.Determinant();
            double? actual = -51622880;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testDet3d()
        {
            double[,] input1 = { { 1, 0, 0}, { 0, 85, 5}, { 0, -1, 85 }};
            MyMatrix matrix = new(input1);
            double? expected = matrix.Determinant();
            double? actual = 7230;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testZeroDet()
        {
            double[,] input1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, -1, 85 } };
            MyMatrix matrix = new(input1);
            double? expected = matrix.Determinant();
            double? actual = 0;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void testZeroDiag()
        {
            double[,] input1 = { { 0, 1, 1 }, { 1, 0, 1 }, { 1, 5, 0 } };
            MyMatrix matrix = new(input1);
            double? expected = matrix.Determinant();
            double? actual = 6;

            Assert.AreEqual(expected, actual);
        }
    }
}
