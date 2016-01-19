using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abundant
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new AbundantNumbers();
            var abundantNumbers = a.GetAbundatnNumbers(28123);
            var sum = a.SumOfNonAbundant(28123, abundantNumbers);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
