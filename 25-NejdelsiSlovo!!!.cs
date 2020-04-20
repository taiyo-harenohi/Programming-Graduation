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
            string my = "";
            int moje = 0;
            string slovo = "";
            int max = 0;
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\slova25.txt", Encoding.Default))
            {
                int znak;
                while ((znak = sr.Read()) != -1)
                {
                    if (znak >= 1 && znak <= 32)
                    {
                        my = "";
                        moje = 0;
                    }
                    else
                    {
                        my += (char)znak;
                        moje++;
                        if (moje > max)
                        {
                            max = moje;
                            slovo = my;
                        }
                    }
                }
            }
            Console.WriteLine("Nejdelší slovo v tomto souboru je {0} a má {1} znaků.", slovo, max);
        }
    }
}
