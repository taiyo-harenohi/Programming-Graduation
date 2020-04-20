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
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\dummytext20.txt", Encoding.Default))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Desktop\dummieTexts\kopie20.txt"))
                {
                    string line;
                    int cislo = 1;
                    while((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine("{0}. {1}", cislo, line);
                        cislo++;
                    }
                }
            }
        }
    }
}
