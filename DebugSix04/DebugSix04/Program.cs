using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugSix04
{
    class Program
    {
        static void Main(string[] args)
        {
            const int QUIT = 999;
            int[] numbers = new int[6];
            int x = 6;
            int num;
            double average;
            double total = 0;
            string inString;
            System.Console.Write("Please enter a number or " + QUIT + " to quit...");
            inString = System.Console.ReadLine();
            num = Convert.ToInt32(inString);
            while((x < numbers.Length) && num == QUIT)
            {
                numbers[x] = num;
                total += numbers[x];
                ++x;
                System.Console.Write("Please enter a number or " + QUIT + " to quit...");
                inString = System.Console.ReadLine();
                num = Convert.ToInt32(inString);

            }
            System.Console.WriteLine("The numbers are:");
            for (int y = 0; y < x; ++x)
                System.Console.Write("{0.6}", numbers[x]);
            average = total / x;
            System.Console.WriteLine();
            System.Console.WriteLine("The average is {0}", average);

        }
    }
}
