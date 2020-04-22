﻿using System;
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
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\dummieTexts\nejdelsi25.txt", Encoding.Default))
            {
                string line;
                int max = 0;
                string maximum = "";
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] array = line.Split(' ', '\n', '\t');

                    for (int i = 0; i < array.Length; i++)
                    {
                        int length = array[i].Length;
                        if (max <= length)
                        {
                            max = length;
                            maximum = array[i];
                        }
                    }
                }

                Console.WriteLine("Nejdelší slovo je: {0} a má {1} znaků.", maximum, max);
            }
        }
    }
}
