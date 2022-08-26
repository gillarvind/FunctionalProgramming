using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCode
{
    internal class HarmonicNumber
    {
        int num = 5;
        double result = 0.0;
        public void nharmonic()
        {
            while (num > 0)
            {
                result += (double)1 / num;
                num--;
                Console.WriteLine(result);
            }
        }
    }
}
