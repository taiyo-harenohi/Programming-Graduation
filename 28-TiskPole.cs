using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // printing out an array... why is this also easy? The fock?
        static void Main(string[] args)
        {
            // calling the method for making an array
            VytvorPole();
        }
        public static void VytvorPole()
        {
            // the array has 10 numbers
            int[] array = new int[10];
            // the numbers are randomized
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next(1, 99);
            }
            // printing out the array
            TiskPole(array);
        }
        public static void TiskPole(int[] pole)
        {
            // using foreach for it
            foreach(int item in pole)
            {
                Console.WriteLine(item);
            }
        }
    }
}
