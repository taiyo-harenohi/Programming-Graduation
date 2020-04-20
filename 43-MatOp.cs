using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        public delegate int matop(int a, int b);
        static void Main(string[] args)
        {
            matop deleg = new matop(MatOp.Součet);

            Tisk(54, 12, MatOp.Součet);
            Tisk(54, 12, MatOp.Rozdíl);
            Tisk(54, 12, MatOp.Součin);
            Tisk(54, 12, MatOp.Podíl);
        }

        public static void Tisk(int a, int b, matop d)
        {
            Console.WriteLine(d(a, b));
        }
    }

    class MatOp
    {
        public static int Součet(int a, int b)
        {
            return a + b;
        }
        public static int Rozdíl(int a, int b)
        {
            return a - b;
        }
        public static int Součin(int a, int b)
        {
            return a * b;
        }
        public static int Podíl(int a, int b)
        {
            return a / b;
        }
    }
}
