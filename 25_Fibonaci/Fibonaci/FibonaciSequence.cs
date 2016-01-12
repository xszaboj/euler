using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibonaci
{
    public class FibonaciSequence
    {
        public int index = 3;


        public BigInteger GetNextNumber(BigInteger number, BigInteger number2)
        {
            index++;
            return number + number2;
        }


        public BigInteger Fibonaci(int numberOfDigits)
        {
            
            BigInteger prev = new BigInteger(1);
            BigInteger prev2 = new BigInteger(1);
            BigInteger current = 2;

            while (current.ToString().ToCharArray().Length < numberOfDigits)
            {
                prev2 = prev;
                prev = current;
                current = GetNextNumber(prev, prev2);                
            }
            return current;
        }
    }
}
