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
            Matice();
        }

        public static void Matice()
        {
            const int n = 3;
            int[,] matice = new int[,] { { 1, 4, 1 }, { 4, 2, 5 }, { 1, 5, 3 } };
            bool symetricka = false;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (matice[i, j] == matice[j, i])
                    {
                        symetricka = true;
                        break;
                    }
                    else
                    {
                        symetricka = false;
                        break;
                    }
                }
            }

            if (symetricka == false)
            {
                Console.WriteLine("Matice je nesymetrická.");
            }
            else
            {
                Console.WriteLine("Matice je symetrická.");
            }
        }
    }
}
