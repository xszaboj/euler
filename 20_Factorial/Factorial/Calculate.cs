using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    public class Calculate
    {
        public BigInteger CalculateFactorial(int factorial)
        {
            if (factorial == 1)
            {
                return new BigInteger(1);
            }
            BigInteger number = new BigInteger(factorial) * CalculateFactorial(factorial - 1);
            return number;
        }
    }
}
