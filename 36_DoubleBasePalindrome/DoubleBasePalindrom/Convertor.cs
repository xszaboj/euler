using System;

namespace DoubleBasePalindrom
{
    public class Convertor
    {
        public static string IntToBinary(int number)
        {
            string binary = Convert.ToString(number, 2);
            return binary;
        }
    }
}
