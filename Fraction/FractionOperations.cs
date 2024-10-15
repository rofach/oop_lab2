using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    partial class MyFrac
    {
        public double DoubleValue()
        {
            return (double)nom / denom;
        }

        public MyFrac Plus(MyFrac f2)
        {
            return new MyFrac(nom * f2.denom + denom * f2.nom,
                              denom * f2.denom);
        }
        public static MyFrac operator +(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom + f1.denom * f2.nom,
                              f1.denom * f2.denom);
        }

        public MyFrac Minus(MyFrac f2)
        {
            return new MyFrac(nom * f2.denom - denom * f2.nom,
                              denom * f2.denom);
        }
        public static MyFrac operator -(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom - f1.denom * f2.nom,
                              f1.denom * f2.denom);
        }

        public MyFrac Multiply(MyFrac f2)
        {
            return new MyFrac(nom * f2.nom, denom * f2.denom);
        }
        public static MyFrac operator *(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.nom, f1.denom * f2.denom);
        }

        public MyFrac Divide(MyFrac f2)
        {
            return new MyFrac(nom * f2.denom, denom * f2.nom);
        }
        public static MyFrac operator /(MyFrac f1, MyFrac f2)
        {
            return new MyFrac(f1.nom * f2.denom, f1.denom * f2.nom);
        }

        public static MyFrac CalcExpr1(int n)
        {
            MyFrac fr = new(0, 1);
            for (long i = 1; i <= n; i++)
            {
                fr = fr + new MyFrac(1, i * (i + 1));
            }
            return fr;
        }
        public static MyFrac CalcExpr2(int n)
        {
            if (n == 1) return new MyFrac(1, 1);
            MyFrac fr = new(1, 1);
            for (long i = 2; i <= n; i++)
            {
                fr = fr * (new MyFrac(1, 1) - new MyFrac(1, i * i));
            }
            return fr;
        }
    }
}
