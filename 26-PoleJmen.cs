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
            string[] name = new string[5];
            for(int i = 0; i < name.Length; i++)
            {
                Console.Write("Napiš jméno: ");
                string namething = Console.ReadLine();
                name[i] = namething;
            }
            Console.WriteLine();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
