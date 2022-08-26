namespace FunctionalCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("select program \n1.Leap Year Program\n2.Power Of Two\n3.Alfa Vowel Porgram\n4.EvenOddnumber Program" +
                    "\n5.FindLargestnumber Program\n6.HarmonicNumber Program\n7.SwapNumber Program\n8.Factor Program\n9.QuotientRem program\n10.FlipCoin Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        LeapYear leapYear = new LeapYear();
                        leapYear.yearcheck();
                        break;
                    case 2:
                        PowerTwo powerTwo = new PowerTwo();
                        powerTwo.powerpro();
                        break;
                    case 3:
                        AlphVow alphVow = new AlphVow();
                        alphVow.alfavow();
                        break;
                    case 4:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.checkev();
                        break;
                    case 5:
                        FindLargest findLargest = new FindLargest();
                        findLargest.largest();
                        break;
                        evenOdd.checkev();
                        break;
                    case 6:
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.nharmonic();
                        break;
                    case 7:
                        SwapNumber swapNumber = new SwapNumber();
                        swapNumber.swap();
                        break;
                    case 8:
                        Factors factors = new Factors();
                        factors.fact();
                        break;
                    case 9:
                        QuoRem quoRem = new QuoRem();
                        quoRem.quorem();
                        break;
                    case 10:
                        FlipCoin flipCoin1 = new FlipCoin();
                        flipCoin1.FlipCo();
                        break;

                    default:
                        Console.WriteLine("enter correct number");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}