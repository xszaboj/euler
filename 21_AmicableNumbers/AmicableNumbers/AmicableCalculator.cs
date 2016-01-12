using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmicableNumbers
{
    public class AmicableCalculator
    {
        public List<int> GetDivisiorsOfNumber(int number)
        {
            List<int> divisiors = new List<int>();
            for(int i=1; i < number; i++)
            {
                if (number % i == 0)
                {
                    divisiors.Add(i);
                }
            }
            return divisiors;
        }

        public int GetDivisorsSum(int number)
        {
            var sum = 0;
            var numbers = GetDivisiorsOfNumber(number);
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public bool IsAmicable(int numberOne, int sumOfDivisorsOfNumberOne)
        {
            int divisorSumTwo = GetDivisorsSum(sumOfDivisorsOfNumberOne);
            return numberOne == divisorSumTwo;
        }
    }
}
