using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // really easy thing; just bunch of if else statements
        static void Main(string[] args)
        {
            Console.Write("Zadej vzdálenost v km, ponožko: ");
            int vzdálenost = int.Parse(Console.ReadLine());

            if (vzdálenost >= 1 && vzdálenost <= 3)
            {
                Console.WriteLine("Platíš {0} Kč.", vzdálenost*15);
            }  
            else if (vzdálenost >= 4 && vzdálenost <= 5)
            {
                Console.WriteLine("Platíš {0} Kč.", vzdálenost * 13);
            } 
            else if (vzdálenost >= 6 && vzdálenost <= 7)
            {
                Console.WriteLine("Platíš {0} Kč.", vzdálenost * 11);
            }  
            else if (vzdálenost >= 8)
            {
                Console.WriteLine("Platíš {0} Kč.", vzdálenost * 10);
            }
            else
            {
                Console.WriteLine("Co to děláš?! You can't cheat the system!");
            }
        }
    }
}
