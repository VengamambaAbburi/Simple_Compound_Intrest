using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public static class Maths
    {
        public static double add(double a, double b)
        {
            return a + b;
        }

        public static double multiply(double a, double b)
        {
            return a*b;
        }

        public static double division(double a, double b)
        {
            return a/b;
        }

        public static double subtraction(double a, double b)
        {
            return a-b;
        }

        public static string simpleInterest(double p, double r, double n)
        {
            double temp = multiply(p, r);

            return Maths.multiply(temp, n).ToString();
        }

        public static string compoundInterest(double p, double r, double n)
        {
            return Maths.multiply(p, Math.Pow(1 + r, n)).ToString();
        }
    }
}
