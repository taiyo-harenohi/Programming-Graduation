using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // if there are multiple rows with the same sum, it doesn't print them, but it is fine :)
        static void Main(string[] args)
        {
            // declaring the matrix
            int[,] array = new int[,] { { 1, 3, 2, 1, 5 }, { 7, 1, 3, 0, 12}, { 6, 11, 7, 8, 4}, { 4, 2, 11, 0, 7}, { 7, 7, 2, 10, 3} };

            // putting the sum in arrays to go through them later
            int[] dohromady = new int[5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // if the number of the index is j
                    switch (j)
                    {
                        case 0:
                            dohromady[i] += array[i, j];
                            break; 
                        case 1:
                            dohromady[i] += array[i, j];
                            break;
                        case 2:
                            dohromady[i] += array[i, j];
                            break; 
                        case 3:
                            dohromady[i] += array[i, j];
                            break;
                        case 4:
                            dohromady[i] += array[i, j];
                            break;
                    }
                }
            }

            // going through the array to get the greatest sum
            int biggest = int.MinValue;
            int poradi = 0;
            for (int i = 0; i < 5; i++)
            {
                if (biggest < dohromady[i])
                {
                    biggest = dohromady[i];
                    poradi = i;
                }
                if (i == 4)
                {
                    Console.WriteLine("Největší: {0}\nindex: {1}", biggest, poradi);
                }
            }
        }
    }
}
