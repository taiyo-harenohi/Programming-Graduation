using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // going through an array to find out if there is a certain number and how many times
        static void Main(string[] args)
        {
            // declaring the array
            int[] array = new int[] { 3, 2, 4, 1, 0, 4, 4, 2, 8, 0, 0, 0, 2, 1, 4, 4, 4, };

            Console.Write("Zadej celé číslo: ");
            int cislo = int.Parse(Console.ReadLine());

            // number of occurences
            int pocet = 0;

            // using foreach to go through the whole array
            foreach (int num in array)
            {
                // if the user's input is the same as the number in the array
                if (num == cislo)
                {
                    // the number of occurences goes up
                    pocet++;
                }
            }

            if (pocet == 0)
            {
                Console.WriteLine("Je mi líto, toto číslo v poli není.");
            }
            else
            {
                Console.WriteLine("Číslo {0} se vyskytuje v poli {1}x.", cislo, pocet);
            }
        }
    }
}
