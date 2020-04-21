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
            // creating List
            List<string> seznam = new List<string>() {"Jawa", "Honda", "Ducati", "Kawasaki", "Suzuki", "BMW", "Yamaha" };
            
            // printing List via foreach
            foreach(string item in seznam)
            {
                Console.WriteLine(item);
            }

            // printing the length of the List
            Console.WriteLine("Délka seznamu: " + seznam.Count);
            
            // printing the amount of memory reversed for the List
            Console.WriteLine("Místo v paměti pro tento počet prvků: " + seznam.Capacity);
            
            // getting index of 'Suzuki'
            Console.WriteLine("Index Suzuki je: " + seznam.IndexOf("Suzuki"));
            
            // removes 'BMW' from the List
            seznam.Remove("BMW");
            
            // searches the List for 'Honda'
            foreach(string item in seznam)
            {
                if (item == "Honda")
                {
                    Console.WriteLine("V seznamu je auto značky Honda.");
                }
            }

            // replacing the item 'Ducati' with 'Indian'
            int index = seznam.IndexOf("Ducati");
            seznam.Remove("Ducati");
            seznam.Insert(index, "Indian");

            // Sorting the List and printing the result
            seznam.Sort();
            foreach (string item in seznam)
            {
                Console.WriteLine(item);
            }
        }
    }
}
