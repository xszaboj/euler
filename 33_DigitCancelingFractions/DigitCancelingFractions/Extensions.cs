using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCancelingFractions
{
    public static class Extensions
    {
        public static int Reduce(this int value, int toReduce)
        {
            int[] numbers = value.ToString().ToCharArray().Select(a => (int)char.GetNumericValue(a)).ToArray();
            int numIndex = Array.IndexOf(numbers, toReduce);
            var n = numbers.Where((val, idx) => idx != numIndex).ToArray();
            if (n.Length == 1)
            {
                return n[0];
            }
            throw new ArgumentException("Length should be 2!");
        }
    }
}
