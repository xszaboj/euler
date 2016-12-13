using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularPrimes;

namespace CircularPrimes_console
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = PrimeNumberGenerator.GetPrimeNumbers(1000000);
            var circularPrimes = new List<CircularPrimeNumber>();
            foreach (var prime in primes)
            {
                circularPrimes.Add(new CircularPrimeNumber(prime));
            }
            var circular = circularPrimes.Where(c => c.IsCircularPrimeNumber()).ToList();
            foreach (var circularPrimeNumber in circular)
            {
                Console.WriteLine(circularPrimeNumber.PrimeNumber);
            }
            Console.WriteLine("There is {0} circular prime numbers under one milion", circular.Count());
            Console.ReadLine();
        }
    }
}
