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
            Console.WriteLine(Bisekce(0, 1, 1e-10));
        }

        static double Bisekce(double a, double b, double eps)
        {
            while (Math.Abs(b - a) > eps)
            {
                double x = (a + b) / 2;
                        if (Funkce(x) * Funkce(a) < 0)
                        {
                            b = x;
                        }
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
