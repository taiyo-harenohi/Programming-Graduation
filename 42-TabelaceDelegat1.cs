using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        public delegate double fun(double x);

        static void Main(string[] args)
        {
            fun deleg = new fun(Funkce.Funkce1);

            Console.WriteLine("f1");
            Tabelace(-1, 1, 0.2, Funkce.Funkce1);
            Console.WriteLine("f2");
            Tabelace(-1, 1, 0.2, Funkce.Funkce2);
        }

        public static void Tabelace(double dolnimez, double hornimez, double krok, fun f)
        {
            for (double i = dolnimez; i <= hornimez; i += krok)
            {
                Console.WriteLine("x = {0:f2}       f(x) = {1:f2}", i, f(i));
            }
        }
    }

    class Funkce
    {
        public static double Funkce1(double x)
        {
            return x * x + 8;
        }

        public static double Funkce2(double x)
        {
            return x * x * x - 3;
        }
    }
}
