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
            // looking through a txt. file to find if the words start and end on the same letter
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\text35.txt", Encoding.Default))
            {
                string line;
                char first = 'v';
                while((line = sr.ReadLine()) != null)
                {
                    line.Trim(); ;
                    string[] array = line.Split(' ', '\n', '\t');

                    // the biggest fuckery here
                    for (int i = 0; i < array.Length; i++)
                    {
                        // using the knowledge that String is an array full of characters
                        string one = array[i];
                        // getting the first letter and comparing it with the last one
                        if (one[0] == one[one.Length - 1])
                        {
                            Console.WriteLine(one);
                        }
                    }
                }
            }

        }
    }
}
