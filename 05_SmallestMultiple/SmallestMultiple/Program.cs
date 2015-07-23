using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            //We dont need to check all numbers, 
            //because if for example number is divisible by 9 it has to be automatically divisible by 3 etc...
            var numbers = new int[] { 19, 18, 17, 16, 15, 14, 13, 11, 9, 7 };
            GetSmallestMultiple(numbers);
            Console.ReadLine();
        }

        private static void GetSmallestMultiple(int[] numbers) {
            for (var i = 1000; i <= Int32.MaxValue; i = i + 20)
            {
                if (IsNumberDivisible(i, numbers))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        private static bool IsNumberDivisible(int number, int[] numbers)
        {
            foreach (var n in numbers)
            {
                if (number % n != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
