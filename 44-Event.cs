using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MaturitaFormalita
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance vydavatele
            Metronom m = new Metronom();
            //instance odběratele
            Listener l = new Listener();
            //přihlášení k odběru
            l.Subscribe(m);
            //metoda pro vyvolání události
            m.Start();
        }
    }
    public class Metronom
    {
        //deklarace delegáta
        public delegate void TickEventHandler(Metronom m, EventArgs e);
        public EventArgs e = null;

        //deklarace události
        public event TickEventHandler Tick;

        //volající metoda
        public void Start()
        {
            while (true)
            {
                Thread.Sleep(3000);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }

    public class Listener
    {
        //metoda pro obsluhu události – eventhandler
        private void HeardIt(Metronom m, EventArgs e)
        {
            Console.WriteLine("Slyšel jsem to!");
        }
        //metoda pro přihlášení odběru
        public void Subscribe(Metronom m)
        {
            m.Tick += new Metronom.TickEventHandler(HeardIt);
        }
    }

}
