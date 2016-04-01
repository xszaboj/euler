using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitFifthPowers
{
    /*
     * Analysis:
     * What is the largest number that can be sum of fifth powers?
     * 999999 => 9^5 * 6 = 354294 [6 digit number]
     * 9999999 => 9^5 * 7 = 413343 [7 digit number]
     * that means that any bigger number than 9999999 will have too many digits and therefore -> number != the sum of digit powers
     */
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            List<int> numbers = new List<int>();
            //1 is not sum
            for (int i = 0; i < 9999999; i++)
            {
                FifthPower pw = new FifthPower(i);
                if (pw.CalculateFifthPowerOfDigits() == i)
                {
                    numbers.Add(i);
                }
            }

            foreach (var number in numbers)
            {
                sum += number;
                Console.WriteLine(number);
            }
            Console.WriteLine("sum: {0}", sum);
            Console.ReadLine();
        }
    }
}
