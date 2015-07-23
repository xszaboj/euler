using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialPythagoreanTriplet
{
    class Program
    {
        /*
         * a = m^2 - n^2
         * b = 2mn
         * c = m^2 + n^2
         * m and n must be coprime
         * m - n must be odd
         * m > n 
         */
        static void Main(string[] args)
        {
            var m = 2; // so m will be always bigger than n
            for (var n = 1; n < 500; n++) {
                for (var j = 1; j < 20; j++)
                {
                    var generatedM = m + j;
                    if (isOdd(generatedM,n) && isCoPrime(n, m + j))
                    {
                        var a = (Math.Pow(generatedM, 2) - Math.Pow(n, 2));
                        var b = 2 * generatedM * n;
                        var c = (Math.Pow(generatedM, 2) + Math.Pow(n, 2));
                        if (a + b + c == 1000)
                        {
                            Console.WriteLine("{0}, {1}, {2}", a, b, c);
                        }
                    }
                }
                m++;
            }
            Console.WriteLine("end");
            Console.ReadLine();
        }

        public static bool isOdd(int m, int n)
        {
            return (m - n) % 2 != 0;
        }

        public static bool isCoPrime(int n, int m)
        {
            for (var i = 2; i < n; i++)
            {
                if (n % i == 0 && m % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
