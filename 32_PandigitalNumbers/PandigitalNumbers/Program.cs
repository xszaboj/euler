using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandigitalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Number> numbers = new List<Number>();
            for (int i = 0; i < 99; i++)
            {
                for (int j = 0; j < 9999; j++)
                {
                    numbers.Add(new Number(i, j));
                }
            }
            int sum = 0;
            List<Number> pandigitals = numbers.Where(s => s.IsPandigital).ToList();
            List<Number> distinctPandigitals = pandigitals
                                              .GroupBy(p => p.Sum)
                                              .Select(g => g.First())
                                              .ToList();
            foreach (var pandigital in distinctPandigitals)
            {
                Console.WriteLine("{0} {1} {2}", pandigital.A, pandigital.B, pandigital.Sum);
                sum += pandigital.Sum;
            }
            Console.WriteLine("sum: {0}", sum);
            Console.ReadLine();
        }
    }
}
