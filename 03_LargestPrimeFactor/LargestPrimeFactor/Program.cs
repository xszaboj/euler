using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeNumbers = new List<long>();
            var original = 600851475143;
            var current = 600851475143;
            long number = 0;
            while (current != number)
            {
                number = GetLargestPrimeNumber(current);
                current = current / number;
                primeNumbers.Add(number);
            }
            var max = primeNumbers.Max();
            Console.WriteLine(max);
            // ---------------- This is just for fun print result -------------------
            Console.WriteLine("---------------");
            for (var i = 0; i < primeNumbers.Count; i++)
            {
                var primeNumber = primeNumbers[i];
                if (i != primeNumbers.Count-1)
                    Console.Write(primeNumber + "x");
                else
                    Console.Write(primeNumber);
            }
            Console.Write(" = " + original);
            Console.WriteLine();
            Console.ReadLine();
            
        }

        private static long GetLargestPrimeNumber(long number)
        {
            if (isPrimeNumber(number))
            {
                return number;
            }
            for (var i = 2; i <= number; i++)
            {
                if (isPrimeNumber(i) && number % i == 0)
                {
                    return i;
                }
            }
            return number;
        }

        private static bool isPrimeNumber(long number)
        {
            var sqrt = Math.Sqrt(number);
            for (int i = 2; i < sqrt; i++)
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
