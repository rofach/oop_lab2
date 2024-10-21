using Matrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMatrix
{
    [TestClass]
    public class TestTranspose
    {
        [TestMethod]
        public void Transpose()
        {
            double[,] arr = new double[2, 3] { { 2, 5, 1 }, { 7, 3, 4 } };
            double[,] exp = new double[3, 2] { {2,7 },{5,3 },{1,4 } };

            MyMatrix matrix = new MyMatrix(arr);
            matrix.TransponeMe();
            double[,] actual = new double[3,2];
            TestMultiply.copyMatrixIntoArray(matrix, actual);

            CollectionAssert.AreEqual(exp, actual);
        }
    }
}
