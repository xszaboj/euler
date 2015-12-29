using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Longest
{
    class Program
    {
        private static Dictionary<double, int> results = new Dictionary<double,int>();

        static void Main(string[] args)
        {
            TestOne();
            TestTwo();
            
            Console.ReadLine();
        }

        private static void TestOne()
        {
        var s = new Stopwatch();
            s.Start();
            var heighest = 0;
            var heighestNumber = 0;
            for (var i = 2; i < 1000000; i++)
            {
                var count = GenerateNumbers(i);
                if (count > heighest)
                {
                    heighest = count;
                    heighestNumber = i;
                }
            }
            s.Stop();
            Console.WriteLine("chain: {0}, number: {1}, time: {2}", heighest, heighestNumber, s.ElapsedMilliseconds);
        }

        private static void TestTwo()
        {
            var s = new Stopwatch();
            s.Start();
            var heighest = 0;
            var heighestNumber = 0;
            for (var i = 2; i < 1000000; i++)
            {
                var count = GenerateNumbers2(i);
                if (count > heighest)
                {
                    heighest = count;
                    heighestNumber = i;
                }
            }
            s.Stop();
            Console.WriteLine("chain: {0}, number: {1}, time: {2}", heighest, heighestNumber, s.ElapsedMilliseconds);
        }

        private static int GenerateNumbers(double number)
        {
            var originalNumber = number;
            var count = 0;
            while (number != 1)
            {
                number = GetNextNumber(number);
                count++;
                if (results.ContainsKey(number))
                {
                    count = count + results[number];
                    results.Add(originalNumber, count);
                    return count;
                }
            }
            results.Add(originalNumber, count);
            return count;
        }

        private static int GenerateNumbers2(double number)
        {
            var count = 0;
            while (number != 1)
            {
                number = GetNextNumber(number);
                count++;
            }
            return count;
        }
        

        private static double GetNextNumber(double number)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
            }
            else
            {
                number = (3 * number) + 1;
            }
            return number;
        }
    }
}
