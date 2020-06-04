using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // some weird work done with List<>, lololol
        static void Main(string[] args)
        {
            List<int> seznam = new List<int>() { 1, 5, 3, 2, 45, 14};

            TiskSeznamu(seznam);
            NaZacatek(seznam);
            VlozZa(seznam);
            Zmena(seznam);
        }

        // the List at the start
        public static void TiskSeznamu(List<int> a) 
        {
            foreach (int number in a)
            {
                Console.Write(number + "    ");
            }
            Console.WriteLine();
        }

        // inserting a number on the start
        public static void NaZacatek(List<int> a)
        {
            a.Insert(0, 21);
            TiskSeznamu(a);
        }

        // inserting number behind a chosen number
        public static void VlozZa(List<int> a)
        {
            Console.Write("Za který index chcete přidat číslo 0? ");
            int index = int.Parse(Console.ReadLine());

            a.Insert(index+1, 0);
            TiskSeznamu(a);
        }

        // multiplying the List<> by two
        public static void Zmena(List<int> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                a[i] = a[i] * 2;
            }
            TiskSeznamu(a);
        }
    }
}
