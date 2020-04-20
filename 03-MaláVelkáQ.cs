using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // the program reads every line and if Q/q is pressed, it ends itself
        static void Main(string[] args)
        {
            bool neníq = false;
            Console.Write("Zapni ten Capslock, ponožko: ");
            while (neníq == false)
            {
                string písmeno = Console.ReadLine();
                if (písmeno.ToLower() == "q")
                {
                    neníq = true;
                    break;
                }
                Console.WriteLine(písmeno.ToLower());
            }
        }
    }
}
