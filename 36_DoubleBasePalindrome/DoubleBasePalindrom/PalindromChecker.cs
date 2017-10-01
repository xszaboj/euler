using System;
using System.Linq;

namespace DoubleBasePalindrom
{
    public class PalindromChecker
    {
        public static bool IsPalindrom(string text)
        {
            return text == new String(text.Reverse().ToArray());
        }
    }
}
