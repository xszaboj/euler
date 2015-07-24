using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 17;
            for (int i = 10; i < 2000000; i++)
            {
                if (IsPrimeNumber(i))
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            var sqrt = Math.Sqrt(number);
            for (int i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
