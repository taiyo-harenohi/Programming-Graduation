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
            PocitaniSVektory pv = new PocitaniSVektory(-1, 3, 2);
            PocitaniSVektory.VelikostVektoru(-1, 3, 2);
        }
    }

    class PocitaniSVektory
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public PocitaniSVektory()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        // Constructors
        public PocitaniSVektory(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static void VelikostVektoru(int x, int y, int z)
        {
            x *= x;
            y *= y;
            z *= z;
            double velikost = Math.Sqrt(x + y + z);
            Console.WriteLine(velikost);
        }
    }
}
