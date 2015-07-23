using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var squareSum = SquareOfSum(100);
            var sumSquare = SumOfSquare(100);
            var difference = squareSum - sumSquare;
            Console.WriteLine(difference);
            Console.ReadLine();
        }

        private static double SquareOfSum(int number)
        {
            var sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum = sum + i;
            }
            return Math.Pow((double)sum,(double)2);
        }

        private static double SumOfSquare(int number)
        {
            double sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += Math.Pow((double)i,(double)2);
            }
            return sum;
        }
    }
}
