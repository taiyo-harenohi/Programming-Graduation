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
        // we are looking for the longest word in a txt. file
        static void Main(string[] args)
        {
            // getting the txt. file
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\nejdelsi25.txt", Encoding.Default))
            {
                string line;
                int max = 0;
                string maximum = "";
                // going through the file line by line
                while ((line = sr.ReadLine()) != null)
                {
                    // getting an array full of the words on the nth line
                    line = line.Trim();
                    string[] array = line.Split(' ', '\n', '\t');

                    // reading the array so we get the longest word
                    for (int i = 0; i < array.Length; i++)
                    {
                        // the length of the word on the i index
                        if (max <= array[i].Length)
                        {
                            // getting how many characters it is and what word it is
                            max = array[i].Length;
                            maximum = array[i];
                        }
                    }
                }

                Console.WriteLine("Nejdelší slovo je: {0} a má {1} znaků.", maximum, max);
            }
        }
    }
}
