using System;
using System.Text;
using System.Numerics;
using PowerOfTwo;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 2;
            int power = 1000;
            BigInteger num = PowerCalculator.Power(number, power);
            double sum = 0;
            foreach (char n in num.ToString().ToCharArray())
            {
                sum += Char.GetNumericValue(n);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
