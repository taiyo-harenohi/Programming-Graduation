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
            int[] array = new int[] { 3, 2, 4, 1, 0, 4, 4, 2, 8, 0, 0, 0, 2, 1, 4, 4, 4, };

            Console.Write("Zadej celé číslo: ");
            int cislo = int.Parse(Console.ReadLine());

            int pocet = 0;
            foreach (int num in array)
            {
                if (num == cislo)
                {
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
