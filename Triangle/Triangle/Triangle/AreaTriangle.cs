using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class AreaTriangle
    {
        public static string rightTriangle(double a, double b, double c)
        {
            double S = 0;
            string min = "";

            if (a != 0 && b != 0)
            {
                S = (a * b / 2);
            }
            else if (a != 0 && c != 0)
            {
                if (a > c) { min = "Данные не верны, катет всегда меньше гипотенузы"; }
                else S = Math.Pow(c, 2) - Math.Pow(a, 2);
            }
            else if (b != 0 && c != 0)
            {
                if (b > c) { min = "Данные не верны, катет всегда меньше гипотенузы"; }
                else S = Math.Pow(c, 2) - Math.Pow(b, 2);
            }
            else min = "Вы ввели не достаточно данных";

            if (min == "") { return Convert.ToString(S); } else return min;
        }
    }
}
