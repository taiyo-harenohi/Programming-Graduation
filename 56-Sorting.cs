using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // using SelectSort; 
        // I recommend using this one or BubbleSort, as they are the easiest
        static void Main(string[] args)
        {
            int[] array = new int[] { 44, 55, 12, 42, 94, 18, 10, 6 };

            Console.WriteLine("Původní – neseřazená posloupnost:");
            Print(array);
            Console.WriteLine();
            SelectSort(array);

            Console.WriteLine("\nPotom – seřazená posloupnost:");
            Print(array);
            Console.ReadLine();
        }

        public static void Print(int[] pole)
        {
            Console.WriteLine();
            foreach(int num in pole)
            {
                Console.Write(num + " ");
            }
        }

        public static void SelectSort(int[] pole)
        {
            // credits to Jožek; my version wouldn't work no matter what :)
            int index_min;
            int min;
            int s = 0;

            while (true)
            {
                min = pole[s];
                for (int i = s; i < pole.Length; i++)
                {
                    if (pole[i] < min)
                    {
                        min = pole[i];
                    }
                }
                index_min = Array.IndexOf(pole, min);
                pole[index_min] = pole[s];
                pole[s] = min;
                Print(pole);
                s++;
                if (pole.Length == s)
                {
                    break;
                }
            }
        }
    }
}
