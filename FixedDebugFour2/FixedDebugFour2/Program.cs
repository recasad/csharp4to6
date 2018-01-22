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
            int num1, num2, num3;
            string snum1, snum2, snum3;
      System.Console.Write("Enter first number ");
      snum1 = System.Console.ReadLine();
      num1 = Convert.ToInt32(snum1);
      System.Console.Write("Enter second number ");
      snum2 = System.Console.ReadLine();
      num2 = Convert.ToInt32(snum2);
      System.Console.Write("Enter third number ");
      snum3 = System.Console.ReadLine();
      num3 = Convert.ToInt32(snum3);
      if(num1 < num2 && num2 < num3)
         System.Console.WriteLine("Numbers are in sequential order");
      else
         if(num1 > num2 && num2 > num3)
            System.Console.WriteLine("Numbers are in reverse order");
         else
            System.Console.WriteLine("Numbers are in neither sequential nor reverse order");
        }
    }
}
