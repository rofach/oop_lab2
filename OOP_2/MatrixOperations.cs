using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    partial class MyMatrix
    {
        public static MyMatrix operator +(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1 == null || matrix2 == null) throw new ArgumentNullException("null reference");
            if (matrix1.Height != matrix2.Height || matrix1.Width != matrix2.Width) throw new ArgumentException("different sizes");
            
            double[,] newMatrix = new double[matrix1.Height, matrix1.Width];

            for (int i = 0; i < matrix1.Height; i++)
            {
                for(int j = 0; j < matrix2.Height; j++)
                {
                    newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return new MyMatrix(newMatrix);


        }

        public static MyMatrix operator *(MyMatrix matrix1, MyMatrix matrix2)
        {
            if (matrix1 == null || matrix2 == null) throw new ArgumentNullException("null reference");
            if (matrix1.Width != matrix2.Height) throw new ArgumentException("impossible to multiply");

            double[,] newMatrix = new double[matrix1.Height, matrix2.Width];

            for(int i = 0; i < matrix1.Height; i++)
            {
                for(int j = 0; j < matrix2.Width; j++)
                {
                    for(int k = 0; k < matrix2.Height; k++)
                    {
                        newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return new MyMatrix(newMatrix);
        }
        
        private double[,] GetTransponedArray()
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            double[,] newMatrix = new double[cols, rows];
            for(int i = 0; i < cols; i++)
            {
                for(int j = 0; j <  rows; j++)
                {
                    newMatrix[i,j]= matrix[j, i];
                }
            }
            return newMatrix;
        }

        public MyMatrix GetTransponedCopy()
        {
            return new MyMatrix(GetTransponedArray());
        }

        public void TransposeMe()
        {
            matrix = GetTransponedArray();
        }

        private void AddRow(double[,] cmatrix, int row1, int row2, double num)
        {
            for (int i = 0; i < Width; i++)
            {
                cmatrix[row2, i] += cmatrix[row1, i] * num;
            }
        }

        private void AddCol(double[,] cmatrix, int col1, int col2, double num)
        {
            for (int i = 0; i < Width; i++)
            {
                cmatrix[i, col2] += cmatrix[i, col1] * num;
            }
        }
        public double? Determinant()
        {
            if (matrix == null) throw new ArgumentNullException("");
            if (Height != Width) throw new ArgumentException("");
            if (determinant != null) return determinant;
            double det = 1;
            if (Height > 2)
            {
                double[,] cmatrix = new double[Height, Width];
                Array.Copy(matrix, cmatrix, Height * Width);
                for(int i = 0; i < Width; i++)
                {
                    if (cmatrix[i, i] == 0)
                    {
                        for(int k = i; k < Height; k++)
                        {
                            if (cmatrix[i, k] != 0)
                            {
                                AddCol(cmatrix, k, i, 1);
                                break;
                            }
                        }
                        if (cmatrix[i, i] == 0)
                        {
                            determinant = 0;
                            return 0;
                        }
                    }
                    for (int j = i + 1; j < Height; j++)
                    {
                        double m = - cmatrix[j, i] / cmatrix[i, i];
                        AddRow(cmatrix, i, j, m);
                    }
                }
                

                for (int i = 0; i < Height; i++)
                    det *= cmatrix[i, i];

                
            }
            else if(Height == 2)
            {
                det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            determinant = det;
            return determinant;
        }
       
    }
}
