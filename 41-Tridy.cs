using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // program showing classes, because this shit is kinda awesome
        // !! need one more method for doing the magic stuff with 
        static void Main(string[] args)
        {
            // declaring the first class, Okno
            Okno o = new Okno("Regex", 120, 200);
            // using a method from this class
            o.Vypis();
            // declaring the second class, Regex
            Regex r = new Regex();
            // using a method from the class
            r.Napis();
        }
    }

    // First class; Parent
    class Okno
    {
        public string typOkna { get; set; }
        public int vyskaOkna { get; set; }
        public int sirkaOkna { get; set; }

        public Okno()
        {
            typOkna = "-";
            vyskaOkna = 0;
            sirkaOkna = 0;
        }

        // constructors

        public Okno(string typ, int vyska, int sirka)
        {
            this.typOkna = typ;
            this.vyskaOkna = vyska;
            this.sirkaOkna = sirka;
        }

        public void Vypis()
        {
            Console.WriteLine("Jsem {0} cm vysoké, {1} cm široké a jsem {2}.", vyskaOkna, sirkaOkna, typOkna);
        }
    }

    // Second class; Child
    class Regex : Okno
    {
        public void Napis()
        {
            Console.WriteLine("Ahoj! (c^-^c)");
        }
    }
}
