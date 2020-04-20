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
            int[,] matrix = { { 4, 2 }, { 6, 2 }, { 7, 3 } };
            Console.Write("Zadej číslo: ");
            int cislo = int.Parse(Console.ReadLine());
            VytvorMatici(matrix, cislo);
        }

        public static void VytvorMatici(int [,] mat, int cislo)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mat[i, j] *= cislo;
                    Console.WriteLine(mat[i, j]);
                }
            }
        }
    }
}
