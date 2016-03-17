using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticPrimes
{
    public class QuadraticPrimes
    {
        public static int GetNumberOfConsecutivesPrimes(int a, int b)
        {
            for (int i = 0; i < 1000; i++)
            {
                int result = CalculateFormula(a, b, i);
                if (!IsPrimeNumber(result))
                {
                    return i;
                }
            }
            return 1000;
        }

        public static int CalculateFormula(int a, int b, int n)
        {
            var result =  (n * n) + (a * n) + b;
            var absolute = Math.Abs(result);
            return absolute;
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number == 0)
            {
                return false;
            }
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

        public static List<int> GetPrimes(int number)
        {
            List<int> primes = new List<int>();
            for (int i = 0; i < number; i++)
            {
                if (IsPrimeNumber(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
    }
}
