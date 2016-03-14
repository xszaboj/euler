using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciprocalCycles
{
    public static class Calculator
    {
        public static int CalculateRemainder(int first, int second)
        {
            return first % second;
        }

        public static int CalculateCycle(int number)
        {
            var numbers = new List<int>();
            int remainder = 1;
            while (!numbers.Contains(remainder) && remainder != 0)
            {
                numbers.Add(remainder);
                remainder = CalculateRemainder((remainder * 10), number);
            }
            if (remainder == 0)
            {
                return 0;
            }
            var index = numbers.IndexOf(remainder);
            var length = numbers.Count;
            return length - index;
        }
    }
}
