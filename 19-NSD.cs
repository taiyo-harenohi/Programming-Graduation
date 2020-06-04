using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // the biggest common divisor
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
            // if residue equals 0 (ie. 4%2), we return number b 
            if (a % b == 0)
            {
                return b;
            }
            // if a is greater than b
            else if (a > b)
            {
                // we divide a with b, b
                return NSD(a % b, b);
            }
            // if b is greater than a
            else
            {
                // b, we divide a with b
                return NSD(b, a % b);
            }
        }
    }
}
