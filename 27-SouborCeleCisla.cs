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
        // reading txt. file – if greater than 0, multiply by 2 / if smaller than 0, put out the abs of the number
        static void Main(string[] args)
        {
            // reading the file line by line
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\cislapro27.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (int.Parse(line) >= 0)
                    {
                        Console.WriteLine(int.Parse(line) * 2);
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(int.Parse(line)));
                    }
                }
            }
        }
    }
}
