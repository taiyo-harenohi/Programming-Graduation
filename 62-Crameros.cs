using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // another Crameros; again, credits go to Pětioký Škorpión
        static void Main(string[] args)
        {
            int[,] matice = new int[,] { { 3, 2, 0}, { -2, 1, 1}, { 2, -1, 4} };
            int[,] pom = new int[3, 3];
            int[,] pom2 = new int[3, 3];

            int[] vektor = new int[] { 5, 0, 15};

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pom[i, j] = matice[i, j];
                    pom2[i, j] = matice[i, j];
                }
            }

            // determinant A
            int determinantA = Determinant(matice);
            Console.WriteLine(determinantA);

            // determinant A1
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matice[j, i] = vektor[j];
                }
            }

            int determinantA1 = Determinant(matice);
            Console.WriteLine(determinantA1);
            
            // determinant A2
            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pom[j, i] = vektor[j];
                }
            }

            int determinantA2 = Determinant(pom);
            Console.WriteLine(determinantA2);
            
            // determinant A3
            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pom2[j, i] = vektor[j];
                }
            }

            int determinantA3 = Determinant(pom2);
            Console.WriteLine(determinantA3);

            Console.WriteLine("X = " + (float)(determinantA1 * 100 / determinantA) / 100);
            Console.WriteLine("Y = " + (float)(determinantA2 * 100 / determinantA) / 100);
            Console.WriteLine("Z = " + (float)(determinantA3 * 100 / determinantA) / 100);
        }

        static int Determinant(int[,] matice)
        {
            int determinant = (matice[0, 0] * matice[1, 1] * matice[2, 2] + matice[1, 0] * matice[2, 1] * matice[1, 2] + matice[2, 0] * matice[1, 1] * matice[1, 2]
                - matice[0, 2] * matice[1, 1] * matice[2, 0] - matice[1, 2] * matice[2, 1] * matice[0, 0] - matice[2, 0] * matice[0, 1] * matice[1, 0]);
            return determinant;
        }
    }
}
