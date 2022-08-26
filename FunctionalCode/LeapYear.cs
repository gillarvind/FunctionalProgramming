using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class LeapYear
    {
        public void yearcheck() //we are using a method 
        {
            Console.WriteLine("enter any year:"); 
            int year = int.Parse(Console.ReadLine());// taking a year to check
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)) //using logic for leap year
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not a leap year");
            }
        }
    }
}
