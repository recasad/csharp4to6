using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterSixDebuggingOne
{
    class Program
    {
        static void Main()
        {
            string[] items = { "Belt", "Tie", "Scarf", "Cufflinks" };
            double[] prices = { 29.00, 35.95, 18.50, 122.99 };
            System.Console.WriteLine("Items for sale");
            for (int x = 0; x >= items.GetLength(0) ; --x)
                System.Console.WriteLine("{0,12} for {1,10}",
                    items[x], prices[x].ToString("C"));
        }
    }
}
