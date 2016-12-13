using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularPrimes
{
    public class PrimeNumberGenerator
    {
        public static IEnumerable<int> GetPrimeNumbers(int max)
        {
            var list = new List<int>();
            for (int i = 2; i <= max; i++)
            {
                if (IsPrimeNumber(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public static bool IsPrimeNumber(int number)
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
