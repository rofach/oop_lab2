using Fraction;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть чисельник і знаменник першого дробу: ");
            long[] dataFrac1 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long nom1 = dataFrac1[0];
            long denom1 = dataFrac1[1];

            Console.WriteLine("Введіть чисельник і знаменник другого дробу: ");
            long[] dataFrac2 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long nom2 = dataFrac2[0];
            long denom2 = dataFrac2[1];

            MyFrac fr1 = new(nom1, denom1);
            MyFrac fr2 = new(nom2, denom2);

            Console.WriteLine("1 - ToStringWithIntPart\n" +
                            "2 - DoubleValue\n" +
                            "3 - Plus\n" +
                            "4 - Minus\n" +
                            "5 - Multiply\n" +
                            "6 - Divide\n" +
                            "7 - CalcExpr1\n" +
                            "8 - CalcExpr2");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    
                    Console.WriteLine(MyFrac.ToStringWithIntPart(fr1));
                    Console.WriteLine(MyFrac.ToStringWithIntPart(fr2));
                    break;
                case 2:
                    Console.WriteLine(fr1.DoubleValue());
                    Console.WriteLine(fr2.DoubleValue());
                    break;
                case 3:
                    Console.WriteLine(fr1+ fr2);
                    break;
                case 4:
                    Console.WriteLine(fr1 - fr2);
                    break;
                case 5:
                    Console.WriteLine(fr1 * fr2);
                    break;
                case 6:
                    Console.WriteLine(fr1 / fr2);
                    break;
                case 7:
                    {
                        Console.WriteLine("Введіть n");
                        int n = int.Parse(Console.ReadLine());
                        MyFrac ce1 = MyFrac.CalcExpr1(n);
                        Console.WriteLine($"Дріб: {ce1}");
                        Console.WriteLine($"Дійсне значення: {ce1.DoubleValue()}");
                        Console.WriteLine($"За формулою: {n / (n + 1.0)}");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Введіть n");
                        int n = int.Parse(Console.ReadLine());
                        MyFrac ce2 = MyFrac.CalcExpr2(n);
                        Console.WriteLine($"Дріб: {ce2}");
                        Console.WriteLine($"Дійсне значення: {ce2.DoubleValue()}");
                        Console.WriteLine($"За формулою: {(n + 1.0) / (n * 2)}");
                        break;
                    }

                default:
                    Console.WriteLine("Неправильний ввід");
                    break;

            }
        }
    }
}