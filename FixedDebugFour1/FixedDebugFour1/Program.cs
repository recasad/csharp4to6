using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;
            String wantChili, wantCheese;
            double price;
            System.Console.Write("Do you want chili on your dog? ");
            wantChili = System.Console.ReadLine();
            System.Console.Write("Do you want cheese on your dog? ");
            wantCheese = System.Console.ReadLine();
            if (wantChili == "Y")
                if (wantCheese == "Y")
                    price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
                else
                    price = BASIC_DOG_PRICE + CHILI_PRICE;
            else
                if (wantCheese == "Y")
                    price = BASIC_DOG_PRICE;
                else
                    price = BASIC_DOG_PRICE;
            System.Console.WriteLine("Your total is {0}", price.ToString("C"));
        }
    }
}
