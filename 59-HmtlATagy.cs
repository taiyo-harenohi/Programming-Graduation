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
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\text59.html", Encoding.Default))
            {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Desktop\dummieTexts\59.txt"))
                {
                    // can be solved via ASCII, too
                    int znak;
                    while ((znak = sr.Read()) != -1)
                    {
                        char jeden = (char)znak;
                        if (jeden == '@')
                        {

                        }
                        else
                        {
                            sw.Write(jeden);
                        }
                    }
                }
            }
        }
    }
}
