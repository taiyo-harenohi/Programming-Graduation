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
        // looking for characters in a "letter" (txt. file)
        static void Main(string[] args)
        {
            // writing the character you are looking for
            Console.Write("Zadej znak, který chceš vyhledat: ");
            char znak = char.Parse(Console.ReadLine());
            // how many times there is a certain character
            int pocetvyskytu = 0;
            // how many characters are in the letter
            int pocetznaku = 0;
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\dopis21.txt", Encoding.Default))
            {
                // reading the file char by char
                int z;
                while ((z = sr.Read()) != -1)
                {
                    // if the char in the file is the same as the certain character
                    if (z == znak)
                    {
                        pocetvyskytu++;
                    }
                    // all the characters
                    pocetznaku++;
                }
            }
            // counting the percent; our character multiplied by 100 and divided by all the characters
            double procent = pocetvyskytu * 100 / pocetznaku;
            Console.WriteLine("Počet výskytů je: {0}, což je {1} % z celkového počtu znaků.", pocetvyskytu, procent);
        }
    }
}
