using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class FindLargest
    {
        public void largest()
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter first number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("first number is largest number" + num1);
            }
            if (num2 > num3 && num2 > num3)
            {
                Console.WriteLine("second number is largest number" + num2);
            }
            else
            {
                Console.WriteLine("third number is largest number" + num3);
            }
        }
    }
}
