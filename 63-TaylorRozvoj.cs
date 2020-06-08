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
        // solved by doing recurrent of the sequence
        static void Main(string[] args)
        {
            // declarition of the things I will need
            double suma = 1;
            int znamenko = 1;
            int n = 4;
            int y = 2;
            double x = 4;
            double mezikrok = 0.0;
            long faktorial = 1;

            // for cycle until it hits n
            for (int i = 0; i < n; i++)
            {
                // we need a factorial; it always has to change to 1 with new cycle
                faktorial = 1;
                // the sign changes each time
                znamenko *= -1;
                // another for cycle for the factorial
                for (int j = 1; j <= y; j++)
                {
                    faktorial *= j;
                }
                // the recurrent writing of the cos x
                mezikrok = Math.Pow(x, y) / (znamenko * faktorial);
                // putting it to the previous result
                suma += mezikrok;
                // for the factorial; it goes up by two
                y += 2;
            }
            Console.WriteLine("Výsledek je: {0:F5}", suma);
        }
    }
}
