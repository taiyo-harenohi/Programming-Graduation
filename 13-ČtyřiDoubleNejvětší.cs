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
            double a = 214.254789;
            double b = 32.147444;
            double c = 88888.214569;
            double d = 5454.2575228;

            Console.WriteLine("Největší ze zadaných čísel je: " + NejvětšíZNich(a, b, c, d));
        }

        public static double NejvětšíZNich(double a, double b, double c, double d)
        {
            double největší = double.MinValue;
            if (a > největší)
            {
                největší = a;
            }
            if (b > největší)
            {
                největší = b;
            }
            if (c > největší)
            {
                největší = c;
            }
            if (d > největší)
            {
                největší = d;
            }
            return největší;
        }
    }
}
