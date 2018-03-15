using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugSix03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] books = {"Catch-22", "Harry Potter",
            "Programing Using C#", "Rich Dad, Poor Dad",
            "The Deep", "Wizar of Oz"};
            int x;
            string entryString;
            System.Console.Write("What book are you looking for? ");
            entryString = Console.ReadLine();
            x =  Array.BinarySearch(books, entryString);
            if (x < 0)
                System.Console.WriteLine("{0} not found", entryString);
            else
                System.Console.WriteLine("Yes, we carry {0}", entryString);

        }
    }
}
