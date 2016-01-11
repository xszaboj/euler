using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PowerOfTwo
{
    public static class PowerCalculator
    {
        public static BigInteger Power(double number, int power)
        {
            BigInteger num = new BigInteger(number);
            return BigInteger.Pow(num, power);
        }
    }
}
