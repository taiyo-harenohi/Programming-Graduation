using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // For some reason, doesn't work, but the algorithm should be right
        static void Main(string[] args)
        {
            double suma = 1;
            int znamenko = 1;
            int n = 4;
            int y = 2;
            double x = 4;
            double mezikrok = 0.0;
            long faktorial = 1;

            for (int i = 0; i < n; i++)
            {
                faktorial = 1;
                znamenko *= -1;
                for (int j = 1; j <= y; j++)
                {
                    faktorial *= j;
                }
                mezikrok = Math.Pow(x, y) / (znamenko * faktorial);
                suma += mezikrok;
                y += 2;
            }
            Console.WriteLine("Výsledek je: {0:F5}", suma);
        }
    }
}
