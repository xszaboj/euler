using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var bb = BitConverter.ToInt64(100000);

        }

        public static BigNumber Multiply(BigNumber one, BigNumber two)
        {
            var numberOneSize = one.SequenceOfNumbers.Count;
            var numberTwoSize = two.SequenceOfNumbers.Count;
            var results = new List<string>();

            for (int i = numberTwoSize -1; i >= 0; i--)
            {
                var result = "";
                result = AddNulls(result, HowManyNullsToAdd(numberTwoSize, i));
                var remainder = 0;
                for (int j = numberOneSize-1; j >= 0; j--)
                {
                    int multiply = Multiply(two.SequenceOfNumbers[i], one.SequenceOfNumbers[j]);
                    multiply = AddRemainder(multiply, remainder);
                    var numberToWrite = GetNumberToWrite(j, multiply);
                    remainder = GetRemainder(j, multiply);
                    result = PrependToResult(result, numberToWrite.ToString());
                }
                AddCurrentResultToResults(result, results);
                ClearResult(result);
            }
            return null;
        }

        private static string AddNulls(string result, int howManyNullsToAdd)
        {
            if (howManyNullsToAdd > 0)
            {
                for (int i = 0; i < howManyNullsToAdd; i++)
                {
                    result = PrependToResult(result, "0");
                }
            }
            return result;
        }
        private static int HowManyNullsToAdd(int numberTwoSize, int loopNumber)
        {
            return numberTwoSize - (loopNumber + 1);
        }
        private static int Multiply(int numberOne, int numberTwo)
        {
            return numberOne * numberTwo;
        }
        private static int AddRemainder(int number, int remainder)
        {
            return number += remainder;
        }
        private static int GetNumberToWrite(int loopNumber, int number)
        {
            int numberToWrite = 0;
            if (loopNumber == 0)
            {
                numberToWrite = number;
            }
            else
            {
                if (number >= 10)
                {
                    numberToWrite = number % 10;
                }
                else
                {
                    numberToWrite = number;
                }
            }
            return numberToWrite;
        }
        private static int GetRemainder(int loopNumber, int number)
        {
            if (loopNumber == 0)
            {
                return 0;
            }
            else
            {
                if (number >= 10)
                {
                    return  number / 10;
                }
                else
                {
                    return 0;
                }
            }
        }
        private static string PrependToResult(string result, string prepend)
        {
            return prepend + result;
        }
        private static void AddCurrentResultToResults(string currentResult, List<string> results)
        {
            results.Add(currentResult);
        }
        private static void ClearResult(string result)
        {
            result = "";
        }
    }
}
