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
            int[] délka = new int[] {2, 14, 5, 7, 8, 6, 12, 8, 10, 0};
            int[] šířka = new int[] {7, 2, 4, 3, 10, 3, 2, 6, 7, 0};

            int řádek = 1;
            for (int i = 0; i< délka.Length; i++)
            {
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
