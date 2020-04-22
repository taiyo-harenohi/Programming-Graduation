using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // Found on the internet, since my work didn't work
        // credits to geeksforgeeks.org, mits
        // using recursive method

        static double p = 1;
        static double f = 1;
        static void Main(string[] args)
        {
            int x = 4;
            int n = 15;
            Console.WriteLine(Math.Round(Ex(x, n), 6));
        }

        static double Ex(int x, int n)
        {
            double r;

            if (n == 0)
            {
                return 1;
            }

            r = Ex(x, n - 1);
            p *= x;
            f *= n;
            return (r + p / f);
        }
    }
}
