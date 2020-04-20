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
            Console.Write("Zadej stranu, ponožko: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadej stranu, ponožko: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Zadej stranu, ponožko: ");
            int c = int.Parse(Console.ReadLine());

            if (a > b + c)
            {
                Console.WriteLine("Toto není možné.");
            }
            else if (b > a + c)
            {
                Console.WriteLine("Toto není možné.");
            }
            else if (c > a + b)
            {
                Console.WriteLine("Toto není možné.");
            }
            else
            {
                if (c * c == a * a + b * b)
                {
                    Console.WriteLine("Trojúhelník je pravoúhlý.");
                }
                else
                {
                    Console.WriteLine("Trojúhelník není pravoúhlý.");
                }
            }
        }
    }
}
