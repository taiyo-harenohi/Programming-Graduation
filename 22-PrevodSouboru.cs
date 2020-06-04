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
        // making a new txt. file out of the old one
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\stary22.txt", Encoding.Default))
            {
                using (StreamWriter sw = new StreamWriter(@"C:\Users\Admin\Desktop\dummieTexts\novy22.txt"))
                {
                    // reading char by char
                    int znak;
                    while((znak = sr.Read()) != -1)
                    {
                        // if the character is a number, we skip it
                        if (znak >= 48 && znak <= 57)
                        {

                        }
                        // if the character is new line, we write a new line too
                        else if (znak == 32)
                        {
                            sw.WriteLine();
                        }
                        // otherwise, we convert it
                        else
                        {
                            // we have to make a new char to put there the character from the file
                            char novy = (char)znak;
                            // then, we have to convert it to string via char.ToString()
                            string novynovy = novy.ToString();
                            // then, the last step is to put all strings to lower via string.ToLower()
                            sw.Write(novynovy.ToLower());
                        }
                    }
                }
            }
        }
    }
}
