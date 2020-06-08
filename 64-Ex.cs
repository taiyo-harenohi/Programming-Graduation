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
        // using recursive method; can be done without it, of course
        // I actually have no idea what is going on, lolol

        static double p = 1;
        static double f = 1;
        static void Main(string[] args)
        {
            int x = 4;
            int n = 15;
            Console.WriteLine(Math.Round(Ex(x, n), 6));
        }

        // declaring the recursive method
        static double Ex(int x, int n)
        {
            double r;

            if (n == 0)
            {
                return 1;
            }

            // calling the method
            r = Ex(x, n - 1);
            p *= x;
            f *= n;
            return (r + p / f);
        }
    }
}
