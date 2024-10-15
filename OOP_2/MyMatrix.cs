using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Matrix
{
    public partial class MyMatrix
    {
        protected double[,] matrix;
        protected double? determinant = null;
        public MyMatrix(MyMatrix matrix)
        {
            int rows = matrix.matrix.GetLength(0);
            int cows = matrix.matrix.GetLength(1);
            this.matrix = new double[rows, cows];
            Array.Copy(matrix.matrix, this.matrix, matrix.matrix.Length);
        }


        public MyMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cows = matrix.GetLength(1);
            this.matrix = new double[rows, cows];
            Array.Copy(matrix, this.matrix, matrix.Length);
        }

        private bool IsRectangle(double[][] arr)
        {
            int rows = arr.Length;
            for (int i = 1; i < rows; i++)
            {
                if (arr[0].Length != arr[i].Length)
                    return false;
            }
            return true;
        }
        public MyMatrix(double[][] matrix)
        {


            if (!IsRectangle(matrix))
            {
                throw new Exception("зубчастий масив не прямокутний");
            }
            int rows = matrix.Length;
            int cols = matrix[0].GetLength(0);
            this.matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.matrix[i, j] = matrix[i][j];
                }
            }

        }

        private bool IsRectangle(string[] str)
        {
            for (int i = 1; i < str.Length; i++)
            {
                if (str[0].Length != str[i].Length)
                {
                    return false;
                }
            }
            return true;
        }
        public MyMatrix(string[] str)
        {
            if (!IsRectangle(str))
                throw new Exception("масив рядків не прямокутний");

            int rows = str.Length;
            int cols = str[0].Length;
            matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] tempArr = Array.ConvertAll(str[i].Trim().Split(), int.Parse);
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = tempArr[j];
                }
            }
        }

     
           
        public MyMatrix(string input)
        {
            string[] str = input.Split(new[] {"\n", "\r"}, StringSplitOptions.RemoveEmptyEntries);

            string[][] strMatrix = new string[str.Length][];

            for (int i = 0; i < str.Length; i++)
            {
                strMatrix[i] = str[i].Split(new[] { " ", "\t" }, StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < strMatrix.Length; i++)
            {

                if (strMatrix[i].Length != strMatrix[0].Length)
                    throw new Exception("не є прямокутним");
               
            }

            int rows = strMatrix.Length;
            int cols = strMatrix[0].Length;

            matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = double.Parse(strMatrix[i][j]);
                }
            }

           
        }

        public int Height
        {
            get { return matrix.GetLength(0); }
        }

        public int Width
        {
            get { return matrix.GetLength(1); }
        }

        public int getHeight()
        {
            return matrix.GetLength(0);
        }

        public int getWidth()
        {
            return matrix.GetLength(1);
        }

        public double getElement(int row, int col)
        {
            return matrix[row, col];
        }

        public void setElement(int row, int col, double value)
        {
            matrix[row, col] = value;
            determinant = null;
        }

        public double this[int index1, int index2]
        {
            get => matrix[index1, index2];
            set
            {
                matrix[index1, index2] = value;
                determinant = null;
            }
        }
        override public string ToString()
        {
            
            StringBuilder sb = new("");
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1); 
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    sb.Append(matrix[i, j]);
                    if(j < cols - 1) sb.Append("\t");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        
    }
}
