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
        // reading a html file and leaving out @, because it is supposed to be a new txt. file
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
                        // changing our int znak to char
                        char jeden = (char)znak;
                        // if it is @, it doesn't do anything
                        if (jeden == '@')
                        {

                        }
                        // otherwise, it writes everything else in the new txt. file
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
