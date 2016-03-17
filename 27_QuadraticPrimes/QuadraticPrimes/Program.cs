using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxlength = -1;
            int maxA = -1;
            int maxB = -1;
            var primes = QuadraticPrimes.GetPrimes(1000);
            foreach (var prime in primes)
            {
                for (int a = -999; a < 1000; a++)
                {
                    var length = QuadraticPrimes.GetNumberOfConsecutivesPrimes(a, prime);
                    if (length > maxlength)
                    {
                        maxlength = length;
                        maxA = a;
                        maxB = prime;
                    }
                }
            }
            Console.WriteLine("A: {0}, B:{1}, length: {2}", maxA, maxB, maxlength);
            Console.WriteLine("a * b = {0}", maxA * maxB);
            Console.ReadLine();
        }
    }
}
