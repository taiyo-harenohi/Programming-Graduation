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
            using (StreamReader sr = new StreamReader(@"C:\Users\Admin\Desktop\realnacisla.txt", Encoding.Default))
            {
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
