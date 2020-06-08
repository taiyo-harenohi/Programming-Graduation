using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // Bisection is not the way, tbh :) but the easiest of them all
        static void Main(string[] args)
        {
            Bisekce(0, 1, 1e-10);
        }

        static double Bisekce(double a, double b, double eps)
        {
            // until the b-a is not smaller than 1e-10
            while (Math.Abs(b - a) > eps)
            {
                // declaration of the x; using the formula
                double x = (a + b) / 2;
                // if the function of x multiplied with function of a is less than 0
                if (Funkce(x) * Funkce(a) < 0)
                {
                    b = x;
                }
                // the other case
                else   
                {
                    a = x;
                }
                Console.WriteLine("{0:F10}      {1:F10}", x, Funkce(x));
            }
            return (a + b) / 2.0;
        }

        public static double Funkce(double x)
        {
            return Math.Cos(x) - x;
        }
    }
}
