using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // trying to get to know if the matrix is symetric or not
        static void Main(string[] args)
        {
            // having a method for the algorithm on its own
            Matice();
        }

        // method for determining if it is symetric or nah
        public static void Matice()
        {
            // declaring matrix
            int[,] matice = new int[,] { { 1, 4, 1 }, { 4, 2, 5 }, { 1, 5, 3 } };
            // declaring bool that checks if the matrix is/is not symetric
            bool symetricka = false;

            // for cycle for going through it
            for (int i = 1; i < matice.GetLength(0); i++)
            {
                for (int j = 0; j < matice.GetLength(1) - 1; j++)
                {
                    // if number on a certain position is the same with the same coordinates but in reverse
                    // it is symetric
                    if (matice[i, j] == matice[j, i])
                    {
                        symetricka = true;
                    }
                    // if not, it is not symetric
                    else
                    {
                        symetricka = false;
                        break;
                    }
                }
            }

            if (symetricka)
            {
                Console.WriteLine("Matice je symetrická.");
            }
            else
            {
                Console.WriteLine("Matice je nesymetrická.");
            }
        }
    }
}
