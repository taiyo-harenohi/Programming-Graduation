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
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\text35.txt", Encoding.Default))
            {
                string line;
                char first = 'v';
                while((line = sr.ReadLine()) != null)
                {
                    line.Trim(); ;
                    string[] array = line.Split(' ', '\n', '\t');

                    for (int i = 0; i < array.Length; i++)
                    {
                        string one = array[i];
                        first = one[0];
                        if (first == one[one.Length - 1])
                        {
                            Console.WriteLine(one);
                        }
                    }
                }
            }

        }
    }
}
