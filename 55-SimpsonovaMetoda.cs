using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Počet n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(metodaSimpson(1, 3, n));
        }

        public static double Funkce(double x)
        {
            return x * x - 5 * x + 13;
        }

        static double metodaSimpson(double a, double b, int n)
        {
            double vysledek = 0;
            double x = a;

            double krokH = (b - a) / n;
            vysledek = (Funkce(a) + 4 * Funkce(a + b / 2) + Funkce(b)) / 3;

            for (double i = 1; i < n; i++)
            {
                x += krokH;
                vysledek += Funkce(x);
            }
            return vysledek * krokH;
        }
    }
}
