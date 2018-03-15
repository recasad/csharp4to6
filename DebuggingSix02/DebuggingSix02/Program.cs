using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingSix02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 15, 22, 88 };
            int x;
            double average;
            double total = 0;
            System.Console.Write("\nThe numbers are...");
            for (x = 0; x < numbers.Length; ++x)
                System.Console.Write("{0, 6}", numbers[x]);
            System.Console.WriteLine();
            for(x = 0; x < numbers.Length; ++x)
            {
                total = numbers[x];
            }
            average = total / numbers.Length;
            System.Console.Write("The average is " + average);
        }
    }
}
