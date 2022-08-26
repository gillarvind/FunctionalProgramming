using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class PowerTwo
    {
        int basenumber, exponent, power, i; 
        public void powerpro()
        {
            Console.Write("Enter any number");
            basenumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter any power: ");
            exponent = Convert.ToInt32(Console.ReadLine());
            power = 1;
            i = 1;
            while (i <= exponent) 
            {
                power = power * basenumber;
                i++;
            }
            Console.Write("Power : " + power);
            Console.ReadLine();
        }
    }
}
