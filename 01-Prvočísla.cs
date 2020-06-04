using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaturitaFormalita
{
    class Prvočísla
    {
        static void Main(string[] args)
        {
            Souborys();
            Console.Write("Zadej číslo, ponožko: ");
            int cislo = int.Parse(Console.ReadLine());
            bool jetoprvocislo = false;

            // solving the problem by using for cycle
            for (int i = cislo - 1; i > 1; i--)
            {
                if (cislo % i == 0) // if we can divide the cislo by any i, it is not a primary number
                {
                    jetoprvocislo = false;
                    break;
                }
                else
                {
                    jetoprvocislo = true;
                }
            }
            if (jetoprvocislo || cislo == 2)
            {
                Console.WriteLine("Je to prvočíslo, lol.");
            }
            else
            {
                Console.WriteLine("Není to prvočíslo, lol.");
            }
        }

        static void Souborys()
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\textdummy.txt", Encoding.Default))
            {
                // reading the file via lines, because there is a number on every line
                // number is in Z; it is the same solution as with the console
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    int num = int.Parse(line);
                    bool jetoprvocislo = true;

                    for (int i = num - 1; i > 1; i--)
                    {
                        if (num % i == 0)
                        {
                            jetoprvocislo = false;
                            break;
                        }
                    }
                    if (jetoprvocislo || num == 2)
                    {
                        Console.WriteLine("{0} je prvočíslo.", num);
                    }
                    else
                    {
                        Console.WriteLine("{0} není prvočíslo.", num);
                    }
                }
            }
        }
    }
}
