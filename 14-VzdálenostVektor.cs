using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // program which uses vectors and the rule for getting the distance between two of them
        static void Main(string[] args)
        {
            // getting the coordinates of three points
            // A[a1,a2]
            Console.Write("");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("");
            int a2 = int.Parse(Console.ReadLine());
            // B[b1,b2]
            Console.Write("");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("");
            int b2 = int.Parse(Console.ReadLine()); 
            Console.Write("");
            // C[c1,c2]
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("");
            int c2 = int.Parse(Console.ReadLine());
            
            // getting the vector of two points: A and B
            VzdálenostVektor(a1, a2, b1, b2);
            // getting triangle out of the three; probably would be good to make sure it is possible, but meh
            Trojuhelnik(a1, a2, b1, b2, c1, c2);
        }

        public static void VzdálenostVektor(int a1, int a2, int b1, int b2)
        {
            // you CAN'T write (b1 - a1)^2 => doesn't work
            int vektor1 = (b1 - a1) * (b1 - a1);
            int vektor2 = (b2 - a2) * (b2 - a2);
            int dohromady = vektor1 + vektor2;
            double vzdalenost = Math.Sqrt(dohromady);
            Console.WriteLine("Vzdálenost zadaných bodů je: {0}", vzdalenost);
        }

        public static void Trojuhelnik(int a1, int a2, int b1, int b2, int c1, int c2)
        {
            int vektorc = ((b1 - a1) * (b1 - a1)) + ((b2 - a2) * (b2 - a2));
            int vektora = ((c1 - b1) * (c1 - b1)) + ((c2 - b2) * (c2 - b2));
            int vektorb = ((c1 - a1) * (c1 - a1)) + ((c2 - a2) * (c2 - a2));
            double vzdálenostc = Math.Sqrt(vektorc);
            double vzdálenosta = Math.Sqrt(vektora);
            double vzdálenostb = Math.Sqrt(vektorb);
            Console.WriteLine("Délka strany a: {0}", vzdálenosta);
            Console.WriteLine("Délka strany b: {0}", vzdálenostb);
            Console.WriteLine("Délka strany c: {0}", vzdálenostc);
            Console.ReadKey();
        }
    }
}
