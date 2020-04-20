using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    delegate void Cisla(int cislo);
    class Program
    {
        static void Main(string[] args)
        {
            // nejde řešit klasickým delegátem, protože void nejde převést; sračka, no
            Random rnd = new Random();
            int num = rnd.Next(0, 99);
            Cisla del; // deklarace delegátu
            Program program = new Program(); // protože metody nejsou statické, tak musí být odkaz na třídu
            // podmínka, u níž nemám sebemenší tušení, jak tvl funguje
            del = (num > 50) ? new Cisla(program.MalaCisla) : new Cisla(program.VelkaCisla);
            del(num); // zavolání onoho delegátu, protože to jinak nic nedělá :)
        }
        void VelkaCisla(int a)
        {
            Console.WriteLine("Malé čislo: " + a);
        }
        void MalaCisla(int a)
        {
            Console.WriteLine("Velké číslo: " + a);
        }
    }
}
