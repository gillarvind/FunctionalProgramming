using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class QuoRem
    {
        int divident = 50, divisor = 8;
        public void quorem()
        {
            Console.WriteLine("enter any divident number:");
            int divident = int.Parse(Console.ReadLine());
            Console.WriteLine("enter any diviser:");
            int divisor = int.Parse(Console.ReadLine());
            int quotient = divident / divisor;
            int reminder = divident % divisor;
            Console.WriteLine("quotient-" + quotient);
            Console.WriteLine("reminder-" + reminder);
        }
    }
}
