using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // Newton: everything is greater than something else in the if-statements
        static void Main(string[] args)
        {
            Newton(0, 1, 1e-10);
        }
        public static void Newton(double a, double b, double eps)
        {
            double x, xs;
            if (Funkce(a) * FunkceDD(a) > 0)
            {
                x = a;
            }
            else
            {
                x = b;
            }
            do
            {
                xs = x;
                x = x - Funkce(x) / FunkceD(x);
                Console.WriteLine("{0:F10}      {1:F10}", x, Funkce(x));
            } while (Math.Abs(x - xs) > eps);
        }

        public static double Funkce(double x)
        {
            return Math.Cos(x) - x;
        }

        public static double FunkceD(double x)
        {
            return -Math.Sin(x) - 1;
        }

        public static double FunkceDD(double x)
        {
            return -Math.Cos(x);
        }

    }
}
