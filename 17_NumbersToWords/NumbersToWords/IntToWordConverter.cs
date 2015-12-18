using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumbersToWords
{
    public class IntToWordConverter
    {
        public string GetText(int number)
        {
            if (number <= 20)
            {
                return GetUpToTwenty(number);
            }
            if(number > 20 && number < 100)
            {
                return GetTenths(number);
            }
            if (number >= 100 && number < 1000)
            {
                return GetHundreds(number);
            }
            if (number == 1000)
            {
                return "one thousand";
            }
            return null;
        }

        private string GetUpToTwenty(int number)
        {
            return words[number];
        }

        private string GetTenths(int number)
        {
            int tenth = number / 10;
            string tenthText = words.ContainsKey(tenth * 10) ? tenthText = words[tenth * 10] : string.Format("{0}ty", words[tenth]);

            int rest = number % 10;
            string text = rest == 0 ? tenthText : string.Format("{0}-{1}", tenthText, words[rest]);
            return text;
        }

        private string GetHundreds(int number)
        {
            int hundreds = number / 100;
            int restTenths = number % 100;
            if (restTenths == 0)
            {
                return string.Format("{0} hundred", words[hundreds]);
            }
            string tenthText = GetText(restTenths);
            return string.Format("{0} hundred and {1}", words[hundreds], tenthText);
        }

        public string GetTextWithoutSpecialCharacters(int number)
        {
            string text = GetText(number);
            //[\s-\-] remove spaces and -
            return Regex.Replace(text, @"[\s-\-]", "");
        }

        private Dictionary<int, string> words = new Dictionary<int, string>()
        {
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            {20, "twenty"},
            {30, "thirty"},
            {40, "forty"},
            {50, "fifty"},
            {80, "eighty"},
        };


    }
}
