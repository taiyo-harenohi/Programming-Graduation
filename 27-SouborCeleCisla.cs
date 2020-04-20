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
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\cislapro27.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int num = int.Parse(line);
                    if (num >= 0)
                    {
                        Console.WriteLine(num * 2);
                    }
                    else
                    {
                        Console.WriteLine(Math.Abs(num));
                    }
                }
            }
        }
    }
}
