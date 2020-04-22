using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        static void Main(string[] args)
        {
            Okno o = new Okno("Regex", 120, 200);
            o.Vypis();
            Regex r = new Regex();
            r.Napis();
        }
    }

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

    class Regex : Okno
    {
        public void Napis()
        {
            Console.WriteLine("Ahoj! (c^-^c)");
        }
    }
}
