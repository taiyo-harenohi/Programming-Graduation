using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // I did it via List<>; it can also be done by using LSS, but...
        // why would you do that?
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> seznam = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                int prvek = rnd.Next(0, 50);
                seznam.Add(prvek);
            }

            foreach(int num in seznam)
            {
                Console.Write("{0}  ", num);
            }
            Console.WriteLine();
            Max(seznam);
        }

        public static void Max(List<int> a)
        {
            int max = int.MinValue;
            foreach(int num in a)
            {
                if (num >= max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
