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
            // counting all of the things in the txt file
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\vstup24.txt", Encoding.Default))
            {
                // the number of line starts with 1, duh
                int cisloradku = 1;
                int pocetznaku = 0;
                int kolikpismen = 0;

                // reading char by char
                int znak;
                while ((znak = sr.Read()) != -1)
                {
                    // if the char is letter(ASCII 65-90; 97-122), +1
                    if ((znak >= 65 && znak <= 90) || (znak >= 97 && znak <= 122))
                    {
                        kolikpismen++;
                    }
                    // all characters on one line
                    pocetznaku++;

                    if (znak == 13)
                    {
                        Console.WriteLine("{0}. řádek: {1} znaků, z čehož {2} jsou písmena.", cisloradku, pocetznaku, kolikpismen);
                        // plus one more line; otherwise, we have to null everything
                        cisloradku++;
                        kolikpismen = 0;
                        pocetznaku = 0;
                    }
                }
            }
        }
    }
}
