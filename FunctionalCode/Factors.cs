using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class Factors
    {
        int num;
        public void fact()
        {
            Console.WriteLine("enter any number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                while (num % i == 0)
                {
                    Console.WriteLine(i + " ");
                    num = num / i;
                }
            }
            if (num >= 2)
            {
                Console.WriteLine(num);
            }
        }
    }
}
