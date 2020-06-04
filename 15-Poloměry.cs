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
        // a file full of r circles => printing it on Console
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\realnacisla.txt", Encoding.Default))
            {
                // reading the file line by line
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    double r = double.Parse(line);
                    Kruhy(r);
                }
            }
        }
        public static void Kruhy(double polomer)
        {
            double obvod = 2 * Math.PI * polomer;
            double obsah = Math.PI * polomer * polomer;

            Console.WriteLine(polomer + "cm      " + obvod + "cm      " + obsah + "cm2");
        }
    }
}
