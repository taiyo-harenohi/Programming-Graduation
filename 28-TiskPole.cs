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
            VytvorPole();
        }
        public static void VytvorPole()
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int next = rnd.Next(1, 99);
                array[i] = next;
            }
            TiskPole(array);
        }
        public static void TiskPole(int[] pole)
        {
            foreach(int item in pole)
            {
                Console.WriteLine(item);
            }
        }
    }
}
