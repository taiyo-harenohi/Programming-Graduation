using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // putting names in the array... why the F is this so easy? :thonking:
        static void Main(string[] args)
        {
            // declaring an array with the length of 5
            string[] name = new string[5];
            // putting the names in the array
            for(int i = 0; i < name.Length; i++)
            {
                Console.Write("Napiš jméno: ");
                name[i] = Console.ReadLine();
            }
            Console.WriteLine();
            // writing the names in the opposite direction
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
