using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // looking for the greatest and smallest number in the matrix and their indexes
        static void Main(string[] args)
        {
            // declaring a matrix
            int[,] array = new int[,] { { 7, 8, 3 }, { 9, 2, 1 }, { 9, 4, 4 } };
            // the greatest number and his indexes
            int max = int.MinValue;
            int maxindexI = 0;
            int maxindexJ = 0;

            // the smallest number and his indexes
            int min = int.MaxValue;
            int minindexI = 0;
            int minindexJ = 0;

            // getting the numbers
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minindexI = i;
                        minindexJ = j;
                    }
                    else if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxindexI = i;
                        maxindexJ = j;
                    }
                }
            }

            Console.WriteLine("Minimální prvek je {0} na indexu {1}{2},\nmaximální prvek je {3} na indexu {4}{5}.", min, minindexI, minindexJ, max, maxindexI, maxindexJ);
            Console.WriteLine();

            // if the matrix has the same m and n, it calls a method
            if (array.GetLength(0) == array.GetLength(1))
            {
                Maximum(array, array.GetLength(0), max, min);
            }
        }

        // the method... there is really nothing much to say
        public static void Maximum(int[,] mat, int rad, int max, int min)
        {
            for (int i = 0; i < rad; i++)
            {
                for (int j = 0; j < rad; j++)
                {
                    if (mat[i, j] < min)
                    {
                        min = mat[i, j];
                    }
                    else if (mat[i, j] > max)
                    {
                        max = mat[i, j];
                    }
                }
            }
            Console.WriteLine("Minimální prvek je {0},\nmaximální prvek je {1}.", min, max);
        }
    }
}
