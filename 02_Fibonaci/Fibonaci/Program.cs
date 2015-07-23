using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = GenerateFiboonaci(4000000);
            numbers.RemoveAll(n => n % 2 != 0);
            Console.WriteLine(numbers.Sum());
            Console.ReadLine();
        }

        private static List<int> GenerateFiboonaci(int upperLimit)
        {
            var fibbonaciNumbers = new List<int>();
            var previous = 0;
            var current = 1;
            var next = 2;
            while (next < upperLimit)
            {
                fibbonaciNumbers.Add(next);
                previous = current;
                current = next;
                next = previous + current;
            }
            return fibbonaciNumbers;
        }
    }
}
