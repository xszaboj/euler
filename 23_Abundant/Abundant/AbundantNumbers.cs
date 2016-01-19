using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abundant
{
    public class AbundantNumbers
    {
        public List<int> GetDivisiorsOfNumber(int number)
        {
            List<int> divisiors = new List<int>();
            for (int i = 1; i < number; i++)
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

        public bool IsAbundant(int number)
        {
            var sum = GetDivisorsSum(number);
            return sum > number;
        }

        public List<int> GetAbundatnNumbers(int toNumber)
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i < toNumber; i++)
            {
                if (IsAbundant(i))
                {
                    numbers.Add(i);
                }
            }
            return numbers;
        }

        public bool IsCombination(List<int> abundantNumbers,List<int> oddAbundantNumbers, int number)
        {
            bool isEven = number % 2 == 0;
            //Even numbers
            if (isEven)
            {
                return IsCombinationForEvenumbers(abundantNumbers, number);
            }
            //Odd numbers
            else
            {
                return IsCombinationForOddNumbers(abundantNumbers, oddAbundantNumbers, number);
            }
            
        }

        public long SumOfNonAbundant(int upperlimit, List<int> abundantNumbers)
        {
            var a = new AbundantNumbers();
            var numbers = new List<int>();
            var odds = abundantNumbers.Where(n => n % 2 != 0).ToList();
            for (int i = 1; i < upperlimit; i++)
            {
                var lowerNumbers = abundantNumbers.Where(n => n < i).ToList();
                var lowerOddNumbers = odds.Where(n => n < i).ToList();
                if (lowerNumbers.Count == 0)
                {
                    numbers.Add(i);
                }
                else
                {
                    var isCombination = a.IsCombination(lowerNumbers, lowerOddNumbers, i);
                    if (!isCombination)
                    {
                        numbers.Add(i);
                    }
                }
            }
            return numbers.Sum();
        }

        private bool IsCombinationForEvenumbers(List<int> abundantNumbers, int number)
        {
            List<int> combinations = new List<int>();
            if (abundantNumbers.Count == 1)
            {
                combinations.Add(abundantNumbers[0] + abundantNumbers[0]);
            }
            else
            {
                for (int i = 0; i < abundantNumbers.Count; i++)
                {
                    var firstNumber = abundantNumbers[i];
                    for (int j = (abundantNumbers.Count - 1); j >= 0; j--)
                    {
                        var secondNumber = abundantNumbers[j];
                        var combination = firstNumber + secondNumber;
                        combinations.Add(combination);
                        if (combination < number)
                        {
                            break;
                        }
                    }
                    if (combinations.Contains(number))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool IsCombinationForOddNumbers(List<int> evenAbundantNumbers, List<int> oddAbundantNumbers, int number)
        {
            //Idea is that even + even so there is no point to count these combinations
            //Se we are interested only in even + odd and there is just few odd abundant numbers 
            List<int> combinations = new List<int>();
            if (oddAbundantNumbers.Count == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < oddAbundantNumbers.Count; i++)
                {
                    var firstNumber = oddAbundantNumbers[i];
                    for (int j = (evenAbundantNumbers.Count - 1); j >= 0; j--)
                    {
                        var secondNumber = evenAbundantNumbers[j];
                        var combination = firstNumber + secondNumber;
                        combinations.Add(combination);
                        if (combination < number)
                        {
                            //No point to continue this combination will be always less
                            break;
                        }
                    }
                    if (combinations.Contains(number))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
