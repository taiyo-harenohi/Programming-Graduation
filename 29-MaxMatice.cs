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
            int[,] array = new int[,] { { 7, 8, 3 }, { 9, 2, 1 }, { 9, 4, 4 } };
            int max = int.MinValue;
            int maxindexI = 0;
            int maxindexJ = 0;

            int min = int.MaxValue;
            int minindexI = 0;
            int minindexJ = 0;

            int rad = 3;

            for (int i = 0; i < rad; i++)
            {
                for (int j = 0; j < rad; j++)
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
            Maximum(array, rad, max, min);
        }

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
