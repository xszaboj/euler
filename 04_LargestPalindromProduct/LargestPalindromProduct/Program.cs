using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratePalindroms();
            Console.ReadLine();
        }

        private static void GeneratePalindroms()
        {
            var heighest = 998001;
            for (var i = heighest; i > 10000; i--)
            {
                if (IsPalindrom(i))
                {
                    var result = GetThreeDigitNumberResult(i);
                    if(result != 0)
                    {
                        Console.WriteLine("palindrom: {0}, result = {1}x{2}", i, result, (i / result));
                        break;
                    }
                }
            }
            
        }

        private static int GetThreeDigitNumberResult(int number) {
            for (int j = 999; j >= 100; j--)
            {
                var result = number;
                if (number % j == 0 && (number/j < 1000) )
                { 
                    return j;
                }
            }
            return 0;
        }

        private static bool IsPalindrom(int number)
        {
            var reverese = ReverseNumber(number);
            if (number == reverese)
            {
                return true;
            }
            return false;
        }

        private static int ReverseNumber(int numb)
        {
            int reverse = 0;
            while (numb > 0)
            {
                int rem = numb % 10;
                reverse = (reverse * 10) + rem;
                numb = numb / 10;

            }
            return reverse;
        }
    }
}
