using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var max = int.MaxValue;
            var j = 0;
            var highest = 0;
            for (int i = 1; i < max && j <= 10001 ; i++)
            {
                if (IsPrimeNumber(i))
                {
                    highest = i;
                    j++;
                }
            }
            Console.WriteLine("10001 Prime number is:{0}", highest);
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
