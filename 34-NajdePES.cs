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
        // You can also solve it via Regex or by reading the file char by char
        // looking for PES in a txt. file; only if it is there or nah
        static void Main(string[] args)
        {
            bool jezde = false;
            using(StreamReader sr = new StreamReader( @"C:\Users\Admin\Desktop\dummieTexts\pes.txt", Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Trim();
                    string[] array = line.Split(' ', '.', ',');

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i].ToUpper() == "PES")
                        {
                            jezde = true;
                            Console.WriteLine("Je to tam!");
                            break;
                        }
                    }
                }
            }
            if (jezde == false)
            {
                Console.WriteLine("Slovo PES se nenašlo. :(");
            }
        }
    }
}
