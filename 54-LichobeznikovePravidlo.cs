using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // Integrals go brrr; trapezoid go brrr
        static void Main(string[] args)
        {
            Console.Write("Počet n: ");
            int n = int.Parse(Console.ReadLine());


            Console.WriteLine(metodaLichoběžník(0, 3.14, n));
        }

        public static double Funkce(double a)
        {
            return Math.Sin(a);
        }

        static double metodaLichoběžník(double a, double b, int n)
        {
            double vysledek = 0;
            double x = a;

            double krokH = (b - a) / n;
            vysledek = (Funkce(a) + Funkce(b)) / 2;
            for (double i = 1; i < n; i++)
            {
                x += krokH;
                vysledek += Funkce(x);
            }
            return vysledek * krokH;
        }
    }
}
