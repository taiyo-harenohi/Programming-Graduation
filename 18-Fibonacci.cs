using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // it works, but it starts with 1, not 0
        static void Main(string[] args)
        {
            Console.Write("Zadej číslo: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(a));
            Console.WriteLine(FibonacciBezR(a));
        }

        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
            }
        }

        public static int FibonacciBezR(int n)
        {
            int a = 0;
            int b = 1;
            // this part is similar to changing values of three variables, but the last one is plus, not only equal
            for (int i = 0; i < n; i++)
            {
                // temporaly = number in a
                int temp = a;
                // a is number in b
                a = b;
                // b plus temporaly number, which is a
                b += temp;
            }
            return a;
        }
    }
}
