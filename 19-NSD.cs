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
            Console.Write("První číslo: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Druhé číslo: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Největší společný dělitel čísel je " + NSD(a, b));

        }

        public static int NSD(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else if (a > b)
            {
                return NSD(a % b, b);
            }
            else
            {
                return NSD(b, a % b);
            }
        }
    }
}
