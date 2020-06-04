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
        // searching through a file to find words starting with a certain letter
        static void Main(string[] args)
        {
            // getting the letter
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

                    // going through the array to find if there are words starting with the particular letter
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        // if stringA.StartsWith(stringB))
                        if (array[i].StartsWith(zacatek.ToString()))
                        {
                            Console.WriteLine(array[i]);
                        }
                    }
                }
            }
        }
    }
}
