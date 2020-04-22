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
            Console.Write("Zadej velikost m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Zadej velikost n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[m,n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Zadej hodnotu m{0}n{1}: ", i+1, j+1);
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int pocitadlo = 1;
            foreach(int item in array)
            {
                Console.Write("{0}  ", item);
                if (pocitadlo % n == 0)
                {
                    Console.WriteLine();
                }
                pocitadlo++;
            }
        }
    }
}
