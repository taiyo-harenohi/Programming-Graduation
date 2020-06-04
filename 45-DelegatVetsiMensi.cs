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
        // which number is greater? Cannot use the usual delegate, but a lil bit different one :) 
        static void Main(string[] args)
        {
            // nejde řešit klasickým delegátem, protože void nejde převést; sračka, no
            Random rnd = new Random();
            int num = rnd.Next(0, 99);

            // deklarace delegátu
            Cisla del;
            // protože metody nejsou statické, tak musí být odkaz na třídu
            Program program = new Program(); 
            // tenární operátor, jak je napsáno v zadání
            del = (num > 50) ? new Cisla(program.MalaCisla) : new Cisla(program.VelkaCisla);
            // zavolání onoho delegátu, protože to jinak nic nedělá :)
            del(num);
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
