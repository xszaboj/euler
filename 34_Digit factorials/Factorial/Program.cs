using System;
using System.Collections.Generic;
using System.Linq;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var same = new List<int>();
            Calculate c = new Calculate();
            for (int i = 11; i < 100000; i++)
            {
                var numbers = ConvertToIntArray(i);
                int sum = numbers.Sum(n => (int) c.CalculateFactorial(n));
                if (i == sum)
                {
                    same.Add(i);
                }
            }
            foreach (var s in same)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        private static int[] ConvertToIntArray(int number)
        {
            return number.ToString().ToCharArray().Select(a => (int)char.GetNumericValue(a)).ToArray();
        }
    }
}
