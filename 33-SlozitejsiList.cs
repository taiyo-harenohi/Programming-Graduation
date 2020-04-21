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
            List<int> seznam = new List<int>() { 1, 5, 3, 2, 45, 14};

            TiskSeznamu(seznam);
            NaZacatek(seznam);
            VlozZa(seznam);
            Zmena(seznam);
        }

        public static void TiskSeznamu(List<int> a) 
        {
            foreach (int number in a)
            {
                Console.Write(number + "    ");
            }
            Console.WriteLine();
        }

        public static void NaZacatek(List<int> a)
        {
            a.Insert(0, 21);
            TiskSeznamu(a);
        }

        public static void VlozZa(List<int> a)
        {
            Console.Write("Za který index chcete přidat číslo 0? ");
            int index = int.Parse(Console.ReadLine());

            a.Insert(index+1, 0);
            TiskSeznamu(a);
        }

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
