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
            Console.Write("");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("");
            int b2 = int.Parse(Console.ReadLine()); 
            Console.Write("");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write("");
            int c2 = int.Parse(Console.ReadLine());
            //VzdálenostVektor(a1, a2, b1, b2);
            Trojuhelnik(a1, a2, b1, b2, c1, c2);
        }

        public static void VzdálenostVektor(int a1, int a2, int b1, int b2)
        {
            int vektor1 = (a2 - a1) ^ 2;
            int vektor2 = (b2 - b1) ^ 2;
            double vzdálenost = Math.Sqrt(vektor1 + vektor2);
            Console.WriteLine("Vzdálenost zadaných bodů je: {0}", vzdálenost);
        }

        public static void Trojuhelnik(int a1, int a2, int b1, int b2, int c1, int c2)
        {
            int vektorc = (a2 - a1) ^ 2 + (b2 - b1) ^ 2;
            int vektora = (b2 - b1) ^ 2 + (c2 - c1) ^ 2;
            int vektorb = (a2 - a1) ^ 2 + (c2 - c1) ^ 2;
            double vzdálenostc = Math.Sqrt(vektorc);
            double vzdálenosta = Math.Sqrt(vektora);
            double vzdálenostb = Math.Sqrt(vektorb);
            Console.WriteLine("Délka strany a: {0}", vzdálenosta);
            Console.WriteLine("Délka strany b: {0}", vzdálenostb);
            Console.WriteLine("Délka strany c: {0}", vzdálenostc);
        }
    }
}
