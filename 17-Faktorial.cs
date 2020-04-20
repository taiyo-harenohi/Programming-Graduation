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
            Console.Write("Zadej číslo n: ");
            int n = int.Parse(Console.ReadLine());
            Faktorial(n);
            Console.WriteLine(Faktorial(n));
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
    }
}
