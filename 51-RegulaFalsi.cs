using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // asi špatně? 
        static void Main(string[] args)
        {
            RegulaFalsi(1.5, 2, 1e-8);
        }
        public static void RegulaFalsi(double a, double b, double eps)
        {
            double xs;
            double x = 0;
            do
            {
                xs = x;
                x = a - (b - a) / ((Funkce(b) - Funkce(a)) * Funkce(a));
                if ((Funkce(a) * Funkce(x)) <= 0)
                {
                    b = x;
                }
                else
                {
                    a = x;
                }
                Console.WriteLine("{0:F10}      {1:F10}", x, Funkce(x));
            } while (Math.Abs(xs - x) > (2 * eps));
            x = (a + b) / 2;
        }

        public static double Funkce(double x)
        {
            return Math.Pow(x / 2, 2) - Math.Sin(x);
        }

    }
}
