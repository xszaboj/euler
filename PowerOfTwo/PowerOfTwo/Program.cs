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
                var addNulls = numberTwoSize - (i + 1);
                var result = "";
                if (addNulls > 0)
                {
                    for (int k = 0; k < addNulls; k++)
                    {
                        result = "0" + result;
                    }
                }
                var remainder = 0;
                for (int j = numberOneSize-1; j >= 0; j--)
                {
                    int multiply = two.SequenceOfNumbers[i] * one.SequenceOfNumbers[j];
                    multiply += remainder;
                    remainder = 0;
                    int numberToWrite = 0;
                    if (j == 0)
                    {
                        numberToWrite = multiply;
                    }
                    else
                    {
                        if (multiply >= 10)
                        {
                            numberToWrite = multiply % 10;
                            remainder = multiply / 10;
                        }
                        else
                        {
                            numberToWrite = multiply;
                        }
                    }
                    result = numberToWrite + result;
                }
                results.Add(result);
                result = "";
            }


            return null;
        }
    }
}
