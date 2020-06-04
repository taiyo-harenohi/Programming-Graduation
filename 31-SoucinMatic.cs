using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // random matrixes work from time to time, but I dunno why, this is the correct answer :shrug:
        static void Main(string[] args)
        {
            int[,] a = Create();
            Print(a);
            Console.WriteLine();
            int[,] b = Create();
            Print(b);

            Console.WriteLine();
            if (a.GetLength(0) == b.GetLength(1))
            {
                Print(Multiply(a, b));
            }
            else
            {
                Console.WriteLine("Nejde to!");
            }
        }

        public static int[,] Create()
        {
            Random rnd = new Random();
            int m = rnd.Next(2, 6);
            int n = rnd.Next(2, 6);
            int[,] a = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rnd.Next(0, 20);
                }
            }
            return a;
        }

        public static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] both = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        // !!! IMPORTANT – we have to have to go through another cycle to get the new number
                        // first has k, j / second i, k
                        both[i, j] += a[k, j] * b[i, k];
                    }
                }
            }
            return both;
        }
    }
}
