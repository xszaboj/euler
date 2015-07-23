using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMultiples());
            Console.ReadLine();
        }

        private static int GetMultiples()
        {
            var multiples = new List<int>();
            for (var i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }

            return multiples.Sum();
        }
    }
}
