using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaturitaFormalita
{
    class Program
    {
        // random stars all on the console with random colours
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            for (int i = 0; i < 1500; i++)
            {
                int width = rnd.Next(0, Console.WindowWidth);
                int height = rnd.Next(0, Console.WindowHeight);
                Console.SetCursorPosition(width, height);
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.Write("*");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
