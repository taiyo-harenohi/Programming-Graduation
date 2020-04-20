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
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\stary22.txt", Encoding.Default))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Desktop\dummieTexts\novy22.txt"))
                {
                    int znak;
                    while((znak = sr.Read()) != -1)
                    {
                        if (znak >= 48 && znak <= 57)
                        {

                        }
                        else if (znak == 32)
                        {
                            sw.WriteLine();
                        }
                        else
                        {
                            char novy = (char)znak;
                            string novynovy = novy.ToString();
                            sw.Write(novynovy.ToLower());
                        }
                    }
                }
            }
        }
    }
}
