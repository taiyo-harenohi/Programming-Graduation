using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // we have to arrays with width and height of rectangles and we have to print ambit bigger than 12
        static void Main(string[] args)
        {
            // preparing two arrays => width and height
            int[] délka = new int[] {2, 14, 5, 7, 8, 6, 12, 8, 10, 0};
            int[] šířka = new int[] {7, 2, 4, 3, 10, 3, 2, 6, 7, 0};

            // printing the number of line
            int řádek = 1;
            // using for cycle; seems like a better option
            for (int i = 0; i< délka.Length; i++)
            {
                // ambit is a + b = o
                int obvod = délka[i] + šířka[i];
                if (obvod > 12)
                {
                    Console.WriteLine("{0}.     {1} cm      {2} cm       {3} cm^2", řádek, délka[i], šířka[i], délka[i] * šířka[i]);
                    řádek++;
                }
            }
        }
    }
}
