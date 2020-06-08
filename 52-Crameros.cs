using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // Crameros; credits go to Pětioký Škorpión, thanks, bro ♥
        static int VypočítejDeterminant(int[,] matice)
        {


            int determinant = (matice[0, 0] * matice[1, 1] * matice[2, 2]) + (matice[0, 1] * matice[1, 2] * matice[2, 0]) + (matice[0, 2]

                       * matice[1, 0] * matice[2, 1]) - (matice[0, 2] * matice[1, 1] * matice[2, 0]) - (matice[0, 0] * matice[1, 2] *
                           matice[2, 1]) - (matice[0, 1] * matice[1, 0] * matice[2, 2]);
            return determinant;
        }

        static void Main(string[] args)
        {
            int[,] matice = new int[,] { { 1, 2, 5 }, { 1, -1, 3 }, { 3, -6, -1 } };
            int[,] pom = new int[3, 3];
            int[,] pom2 = new int[3, 3];

            int[] vektor = new int[] { -9, 2, 25 };

            int determinantA = VypočítejDeterminant(matice);  
            Console.WriteLine("Determinant A je roven = {0}", VypočítejDeterminant(matice));

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pom[i, j] = matice[i, j];       
                    pom2[i, j] = matice[i, j];
                }

            }
 
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matice[j, i] = vektor[j];
                }

            }

            int determinantA1 = VypočítejDeterminant(matice);
            Console.WriteLine("Determinant A1 je roven = {0}", VypočítejDeterminant(matice));

            for (int i = 1; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pom[j, i] = vektor[j];  
                }

            }
            int determinantA2 = VypočítejDeterminant(pom);
            Console.WriteLine("Determinant A2 je {0}", VypočítejDeterminant(pom));

            for (int i = 2; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pom2[j, i] = vektor[j];        
                }

            }
            int determinantA3 = VypočítejDeterminant(pom2);
            Console.WriteLine("Determinant A3 je {0}", VypočítejDeterminant(pom2));
            Console.BackgroundColor = ConsoleColor.Red;
            if (determinantA == 0)
            {
                Console.WriteLine("Determinant A vyšel 0, průser, nulou dělit nejde");      // klasické stanoshovno

            }
            else
            {
                Console.WriteLine("X této soustavy rovnic je rovno: {0}", determinantA1 / determinantA);
                Console.WriteLine("Y této soustavy rovnic je rovno: {0}", determinantA2 / determinantA);
                Console.WriteLine("Z této soustavy rovnic je rovno: {0}", determinantA3 / determinantA);
            }
            Console.Read();
        }
    }
}
