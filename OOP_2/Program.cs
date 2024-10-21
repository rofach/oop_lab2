using Matrix;

namespace MainProgram
{
    class Programm()
    {
        static void Main(string[] args)
        {

            
            string input1 = "";
            string input2 = "";
            try
            {
                input1 = File.ReadAllText("input1.txt");
                input2 = File.ReadAllText("input2.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                //MyMatrix matrix1 = new(input1);
                //MyMatrix matrix2 = new(input2);

                //double[][] ainput1 = new double[][] { new double[] { 1, 0, 0, 85 }, new double[] { 0, 85, 5, 0 }, new double[] { 0, -1, 85, 2 }, new double[] { 85, 0, 4, 85 } };
                //double[,] ainput2 = { { 1, 0, 0 }, { 0, 5, 1 }, { 0, 85, 0 }, { 85, 0, 4 } };

                //string str = "1 2   3 4\n 3  1 2 3\n 4 2 4 \t \t 1 4\n 1 2 2 2";
                //MyMatrix test = new(str);
                //Console.WriteLine(test);

                MyMatrix matrix1 = new(input1);
                MyMatrix matrix2 = new(input2);

                Console.WriteLine("matrix1");
                Console.WriteLine(matrix1);

                matrix1.TransposeMe();
                Console.WriteLine("matrix1 ttt");
                Console.WriteLine(matrix1);
                Console.WriteLine("matrix2");
                Console.WriteLine(matrix2);


                Console.WriteLine("add");
                //Console.WriteLine(matrix1 + matrix2);
                //Console.WriteLine("multiply");
                //Console.WriteLine(matrix1 * matrix2);

                //Console.WriteLine("transpond");
                //nsole.WriteLine(matrix1.GetTransponedCopy());

                Console.WriteLine("det");
                
                Console.WriteLine(matrix1.Determinant());
                //Console.WriteLine(matrix1.Determinant());


                

               
            }


        }
    }
}