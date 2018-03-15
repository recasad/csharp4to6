using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[7];
            int x, y;
            string strNUmbers;
            int num;

            for (x = 0; x < 7; x++)
            {
                System.Console.Write("Please enter a number");
                strNUmbers = Console.ReadLine();
                num = Convert.ToInt32(strNUmbers);
                numbers[x] = num;
        
            }
            Console.WriteLine();
            Array.Reverse(numbers);
            Console.WriteLine("{0,1,2,3,4,5,6,7}", numbers);
        }
    }
}
