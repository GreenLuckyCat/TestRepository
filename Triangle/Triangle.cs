using System;

namespace ru.Company.Library
{

    public static class Triangle
    {

        public static bool IsValid(double a, double b)
        {
            return a >= 0.0 && b >= 0.0;
        }

        public static bool IsValid(double a, double b, double c, int precision = 15)
        {
            var positive = a >= 0.0 && b >= 0.0 && c >= 0.0;
            if (positive) {
                var cat1 = (a > c ? c : a);
                var cat2 = (b > c ? c : b);
                var hyp = Math.Max(Math.Max(a, b), c);

                positive = Math.Round(cat1 * cat1 + cat2 * cat2, precision) == Math.Round(hyp * hyp, precision);
            }
            return positive;
        }

        public static double CalcArea(double a, double b)
        {
            return a * b * 0.5;
        }


        public static double CalcArea(double a, double b, double c)
        {
            var p = (a + b + c) * 0.5; // полупериметр
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
   }
}
