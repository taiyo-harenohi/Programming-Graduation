using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // we have 4 double numbers and we have to choose the biggest one
        // using formal and real parametres in method
        static void Main(string[] args)
        {
            double a = 214.254789;
            double b = 32.147444;
            double c = 88888.214569;
            double d = 5454.2575228;

            Console.WriteLine("Největší ze zadaných čísel je: " + NejvětšíZNich(a, b, c, d));
        }

        // the method is a return type; it returns the biggest of them
        public static double NejvětšíZNich(double a, double b, double c, double d)
        {
            // getting the smallest possible number there is to compare it with our four doubles
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
