using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    // this program puts out what kind of money you will need to pay the input
    // actually kind of hard
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej počet peněz v tvé peněžence (do 200,-): ");
            int obnos = int.Parse(Console.ReadLine());

                if (obnos >= 50)
                {
                    Console.WriteLine("Počet 50 Kč: {0}", obnos / 50);
                    obnos -= (obnos / 50) * 50;
                }
                if (obnos >= 20)
                {
                    Console.WriteLine("Počet 20 Kč: {0}", obnos / 20);
                    obnos -= (obnos / 20) * 20;
                }
                if (obnos >= 10)
                {
                    Console.WriteLine("Počet 10 Kč: {0}", obnos / 10);
                    obnos -= (obnos / 10) * 10;
                }
                if (obnos >= 5)
                {
                    Console.WriteLine("Počet 5 Kč: {0}", obnos / 5);
                    obnos -= (obnos / 5) * 5;
                }
                if (obnos >= 2)
                {
                    Console.WriteLine("Počet 2 Kč: {0}", obnos / 2);
                    obnos -= (obnos / 2) * 2;
                }     
                if (obnos != 0)
                {
                    Console.WriteLine("Počet 1 Kč: {0}", 1);
                }
        }
    }
}
