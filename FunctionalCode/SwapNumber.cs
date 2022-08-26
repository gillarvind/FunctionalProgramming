using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class SwapNumber
    {
        int num1 = 23;
        int num2 = 45;
        int temp;
        public void swap()
        {
            Console.WriteLine("before swapping number");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("after swapping number");
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
