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
        // I recommend using this one, InsertSort or BubbleSort, as they are the easiest
        static void Main(string[] args)
        {
            // declaring array
            int[] array = new int[] { 2, 4, 5, 6, 1, 3, 0, 8, -2 };
            Print(Sorting(array));
        }

        // method for printing array
        public static void Print(int[] ar)
        {
            foreach(int num in ar)
            {
                Console.Write("{0}  ", num);
            }
        }

        public static int[] Sorting(int[] ar)
        {
            // we have to remember that the princip of SelectSort is finding the min in the array and swipe it with array[0]
            
            // declaring min and an empty variable to change values later on
            int min, pom = 0;
            // going through the array
            for (int i = 0; i < ar.Length - 1; i++)
            {
                // min is now the same number as i
                min = i;
                // going through the array to find the smallest number
                for (int j = i; j < ar.Length; j++)
                {
                    // if number on ar[min] is greater than on ar[j], we change the min
                    if (ar[j] < ar[min])
                    {
                        min = j;
                    }
                }
                // changing the values of three variables
                pom = ar[i];
                ar[i] = ar[min];
                ar[min] = pom;
            }
            return ar;
        }
    }
}
