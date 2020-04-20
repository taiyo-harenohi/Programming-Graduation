using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // nefunguje pro více stejných součtů, ale to asi nevadí tolik :)
        static void Main(string[] args)
        {
            int[,] array = new int[,] { { 1, 3, 2, 1, 5 }, { 7, 1, 3, 0, 12}, { 6, 11, 7, 8, 4}, { 4, 2, 11, 0, 7}, { 7, 7, 2, 10, 3} };

            int[] dohromady = new int[5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
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
