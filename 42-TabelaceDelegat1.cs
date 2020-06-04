using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // using delegates to help us with declaring class and calling methods inside of it

        // declaring delegate – public/private delegate type name(parameter)
        public delegate double fun(double x);

        static void Main(string[] args)
        {
            // using delegate in the method; the "declarition" proccess
            fun deleg = new fun(Funkce.Funkce1);

            Console.WriteLine("f1");
            // calling a method Tabelace
            Tabelace(-1, 1, 0.2, Funkce.Funkce1);
            Console.WriteLine("f2");
            Tabelace(-1, 1, 0.2, Funkce.Funkce2);
        }

        // method for writing out the function
        public static void Tabelace(double dolnimez, double hornimez, double krok, fun f)
        {
            for (double i = dolnimez; i <= hornimez; i += krok)
            {
                Console.WriteLine("x = {0:f2}       f(x) = {1:f2}", i, f(i));
            }
        }
    }

    // class full of functions
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
