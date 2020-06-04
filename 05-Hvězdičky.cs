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
                // getting width of the window by using Console.WindowWidth
                int width = rnd.Next(0, Console.WindowWidth);
                // getting height of the window by using Console.WindowHeight
                int height = rnd.Next(0, Console.WindowHeight);
                // we have to put the cursor on the numbers we got = the X and Y
                Console.SetCursorPosition(width, height);
                // getting one of the sixteen numbers, completely randomized
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.Write("*");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
