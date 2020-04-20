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
            int a = 2;
            int b = 2;
            int c = 1;
            int d = 0;
            int e = 4;

            Console.WriteLine("První příklad: {0}", a++/++c * --e);
            a = 2;
            c = 1;
            e = 4;

            Console.WriteLine("Druhý příklad: {0}", --b * c++ - a);
            a = 2;
            c = 1;
            b = 2;

            Console.WriteLine("Třetí příklad: {0}", -b - --c);
            c = 1;
            b = 2;

            Console.WriteLine("Čtvrtý příklad: {0}", ++a - --e);
            a = 2;
            e = 4;

            Console.WriteLine("Pátý příklad: {0}", e / --a * b++ / c++);
            a = 2;
            b = 2;
            c = 1;
            e = 4;

            Console.WriteLine("Šestý příklad: {0}", a %= b = d = 1 + e / 2);
        }
    }
}
