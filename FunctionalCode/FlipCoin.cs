using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class FlipCoin
    {
        int head = 0;
        int tail = 0;
        int count = 1;
        public void FlipCo()
        {
            Console.WriteLine("enter any number");
            int flips = Convert.ToInt32(Console.ReadLine());
            while (count <= flips)
            {
                Random random = new Random();
                double check = random.NextDouble();
                Console.WriteLine(check);
                if (check < 0.5)
                {
                    tail++;
                    Console.WriteLine("tail");
                }
                else
                {
                    head++;
                    Console.WriteLine("head");
                }
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("number of heads:" + head);
            Console.WriteLine("number of tails:" + tail);
            double headper = (double)head / flips * 100;
            double tailper = (double)tail / flips * 100;
            Console.WriteLine("head percentage:" + headper);
            Console.WriteLine("tail percentage:" + tailper);
        }
    }
}
