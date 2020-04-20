using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaturitaFormalita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej znak, který chceš vyhledat: ");
            char znak = char.Parse(Console.ReadLine());
            int pocetvyskytu = 0;
            int pocetznaku = 0;
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\dopis21.txt", Encoding.Default))
            {
                int z;
                while ((z = sr.Read()) != -1)
                {
                    if (z == znak)
                    {
                        pocetvyskytu++;
                    }
                    pocetznaku++;
                }
            }
            double procent = pocetvyskytu * 100 / pocetznaku;
            Console.WriteLine("Počet výskytů je: {0}, což je {1} % z celkového počtu znaků.", pocetvyskytu, procent);
        }
    }
}
