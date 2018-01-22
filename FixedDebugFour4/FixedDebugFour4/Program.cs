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
            double sales, commission;
            string inputString;
            const int LOWSALES = 1000;
            const int MEDSALES = 5000;
            const int HIGHSALES = 10000;
            const double LOWPCT = 0.05;
            const double MEDPCT = 0.02;
            const int BONUS1 = 1000;
            const int BONUS2 = 1500;
           System.Console.WriteLine("What was the sales amount? ");
            inputString = System.Console.ReadLine();
            sales = Convert.ToDouble(inputString);
            commission = LOWPCT * sales;
            if (sales < MEDSALES)
                commission += (sales - LOWSALES) * MEDPCT;
            else
                if (sales < HIGHSALES && sales >= MEDSALES)
                    commission += BONUS1;
                else
                    if (sales >= HIGHSALES)
                        commission = BONUS2;
            System.Console.WriteLine("Sales: {0}\nCommission: {1}",
              sales.ToString("C"), commission.ToString("C"));
        }
    }
}
