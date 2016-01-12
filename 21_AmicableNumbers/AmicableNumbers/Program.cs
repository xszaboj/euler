using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicableNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AmicablePair> pairs = new List<AmicablePair>();
            var a = new AmicableCalculator();

            for (int i = 1; i < 10000; i++)
            {
                var sumOfDivisors = a.GetDivisorsSum(i);
                if (a.IsAmicable(i, sumOfDivisors))
                {
                    pairs.Add(new AmicablePair() { FirstNumber = i, SecondNumber = sumOfDivisors });
                }
            }

            pairs = pairs.Where(elm => elm.FirstNumber != elm.SecondNumber).ToList();

            var sum = 0;
            foreach (var pair in pairs)
            {
                sum += pair.FirstNumber;
                sum += pair.SecondNumber;
            }

            Console.WriteLine(sum / 2);

            Console.ReadLine();
        }
    }
}
