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
        // it was here already, so fuck it; you just write the words yourself, lol
        static void Main(string[] args)
        {
            Console.Write("Kolik slov chcete zapsat? ");
            int pocetSlov = int.Parse(Console.ReadLine());


            using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Desktop\dummieTexts\nejdelsislovo36.txt"))
            {
                for (int i = 0; i < pocetSlov; i++)
                {
                    Console.Write("{0}. slovo: ", i+1);
                    string slovo = Console.ReadLine();
                    sw.WriteLine(slovo);
                }
            }

            string nejdelsi = "";
            int max = 0;

            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\nejdelsislovo36.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Length > max)
                    {
                        nejdelsi = line;
                        max = line.Length;
                    }
                }
            }

            Console.WriteLine("Nejdelší slovo je: {0}, počet znaků je {1}.", nejdelsi, max);
        }
    }
}
