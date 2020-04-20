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
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\vstup24.txt", Encoding.Default))
            {
                int cisloradku = 1;
                int pocetznaku = 0;
                int kolikpismen = 0;

                int znak;
                while ((znak = sr.Read()) != -1)
                {
                    if ((znak >= 65 && znak <= 90) || (znak >= 97 && znak <= 122))
                    {
                        kolikpismen++;
                    }
                    pocetznaku++;

                    if (znak == 13)
                    {
                        Console.WriteLine("{0}. řádek: {1} znaků, z čehož {2} jsou písmena.", cisloradku, pocetznaku, kolikpismen);
                        cisloradku++;
                        kolikpismen = 0;
                        pocetznaku = 0;
                    }
                }
            }
        }
    }
}
