using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HighlyDivisibleTriangularNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            var hasFiveHundredDivisors = false;
            int number = 0;
            var primeNumbers = GetPrimeNumbers(100000);
            while(hasFiveHundredDivisors == false)
            {
                if (number == int.MaxValue)
                {
                    Console.WriteLine("preteceno");
                }
                sum = Program.GetNextTriangularNumber(number, sum);
                var divisors = GetDivisors(sum, primeNumbers.ToArray());
                if (divisors >= 500)
                {
                    hasFiveHundredDivisors = true;
                }
                number++;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static List<int> GetPrimeNumbers(int number)
        {
            var primeNumbers = new List<int>();
            for (int i = 2; i < number; i++)
            {
                if (IsPrimeNumber(i))
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }


        public static double GetNextTriangularNumber(int number, double sum)
        {
            return (sum + (number + 1));
        }

        public static int GetDivisors(double number, int[] primeNumbers)
        {
            var divisors = 1;
            var i = 0;
            int exp = 1;
            while (number >= primeNumbers[i])
            {
                if (number%primeNumbers[i] == 0)
                {
                    number = number / primeNumbers[i];
                    exp++;
                }
                else
                {
                    divisors *= exp;
                    i++;
                    exp = 1;
                }
            }
            return divisors*exp;
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
