using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            BigInteger result = c.CalculateFactorial(100);
            double sum = 0;
            char[] array = result.ToString().ToArray<char>();
            foreach (char number in array)
            {
                sum += Char.GetNumericValue(number);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
