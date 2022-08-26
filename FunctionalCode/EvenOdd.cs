using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class EvenOdd
    {
        public void checkev()
        {
            Console.WriteLine("enter any number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("this is even number");
            }
            else
            {
                Console.WriteLine("this is odd number");
            }
        }
    }
}
