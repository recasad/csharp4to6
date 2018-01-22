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
            int credits, year;
            string inputString;
            double tuition;
            const int LOWCREDITS = 12;
            const int HIGHCREDITS = 18;
            const double HOURFEE = 15000;
            const double DISCOUNT = 0.15;
            const double FLAT = 1900.00;
            const double RATE = 100.00;
            const int SENIORYEAR = 4;
            System.Console.WriteLine("How many credits? ");
            inputString = System.Console.ReadLine();
            credits = Convert.ToInt32(inputString);
            System.Console.WriteLine("Year in school? ");
            inputString = System.Console.ReadLine();
            year = Convert.ToInt32(inputString);
            if (credits > LOWCREDITS)
                tuition = HOURFEE * credits;
            else
                if (credits == HIGHCREDITS)
                    tuition = FLAT;
                else
                    tuition = FLAT + (credits - HIGHCREDITS) * RATE;
            if (year < SENIORYEAR)
                tuition = tuition - (tuition * DISCOUNT);
            System.Console.WriteLine("For year {0}, with {1} credits",
               year, credits);
            System.Console.WriteLine("Tuition is {0}", tuition.ToString("C"));
        }
    }
}
