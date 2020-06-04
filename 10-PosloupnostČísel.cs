using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // the biggest number in the array + how many times it is in it
        static void Main(string[] args)
        {
            int[] array = new int[] {31, 6, 92, 1, 15, 18, 21, 41, 18, 92, 4, 6, 0};
            int max = int.MinValue;
            // using foreach, because it is the fastest way to do it
            foreach (int n in array)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            int početn = 0;
            // have to go through the array again, because the first time we are looking for the biggest one
            foreach (int n in array)
            {
                if (n == max)
                {
                    početn++;
                }
            }
            Console.WriteLine("Největší číslo: {0}; objevuje se v posloupnosti {1}x", max, početn);
        }
    }
}
