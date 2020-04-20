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
            Console.Write("Zapiš řetězec: ");
            int znak;
            while ((znak = Console.Read()) != -1)
            {
                if (znak == 13)
                {
                    break;
                }
                Console.WriteLine("{0} --- {1} --- {2}", (char)znak, znak.ToString("X"), Convert.ToDecimal(znak));
            }
        }
    }
}
