using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // writing recursive and non-recursive method for solving factorial
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Faktorial(n));
            Console.WriteLine(FaktorialBezR(n));
        }
        public static long Faktorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Faktorial(n - 1);
            }
        }

        public static long FaktorialBezR(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
            }
            return n;
        }
    }
}
