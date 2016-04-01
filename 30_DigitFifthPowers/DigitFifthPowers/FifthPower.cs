using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitFifthPowers
{
    public class FifthPower
    {
        private int number;
        private char[] digits;

        public FifthPower(int number)
        {
            this.number = number;
            this.digits = number.ToString().ToCharArray();
        }

        public double CalculateFifthPowerOfDigits()
        {
            double sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += CalculateFifthPower(char.GetNumericValue(digits[i]));
            }
            return sum;
        }

        private double CalculateFifthPower(double i)
        {
            return Math.Pow(i, 5);                 
        }
    }
}
