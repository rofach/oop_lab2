using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public partial class MyFrac
    {
        private long nom, denom;
        public MyFrac(long nom, long denom)
        {
            int sign = 1;
            if ((double)nom / denom < 0)
                sign = -1;

            long t_nom = Math.Abs(nom);
            long t_denom = Math.Abs(denom);
            
            while (t_nom != 0 && t_denom != 0)
            {
                if (t_nom > t_denom)
                    t_nom %= t_denom;
                else
                    t_denom %= t_nom;
            }
            long gcd = t_nom | t_denom;
            this.nom = Math.Abs(nom) / gcd * sign;
            this.denom = Math.Abs(denom) / gcd;
        }
        public static string ToStringWithIntPart(MyFrac f)
        {
            string sign = "";
            if (f.nom < 0) sign = "-";
            long intPart = Math.Abs(f.nom) / f.denom;
            long nom = Math.Abs(f.nom) - intPart * f.denom;
            return $"{sign}({(intPart == 0 ? "" : intPart.ToString() + (nom == 0 ? "" : "+"))}{(nom == 0 ? "" : new MyFrac(nom, f.denom))})";
        }

        public override string ToString()
        {
            return nom + "/" + denom;
        }
    }
}
