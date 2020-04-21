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
            Console.Write("Vypiš písmeno, na které má dané slovo začínat: ");
            char zacatek = (char)Console.Read();

            Console.WriteLine();

            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\text37.txt", Encoding.Default))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] array = line.Split(' ', '\n', '\t');

                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        string a = array[i];
                        string b = zacatek.ToString();

                        if (a.StartsWith(b))
                        {
                            Console.WriteLine(a);
                        }
                    }
                }
            }
        }
    }
}
