using DoubleBasePalindrom;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoubleBasePalindromCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets calculate some palindromes!");

            var dict = new Dictionary<int, string>();

            for (int i = 1; i <= 1000000; i++)
            {
                if (PalindromChecker.IsPalindrom(i.ToString()))
                {
                    var binary = Convertor.IntToBinary(i);
                    if (PalindromChecker.IsPalindrom(binary))
                    {
                        dict.Add(i, binary);
                        Console.WriteLine($"new palindrom found. {i} : {binary} ");
                    }
                }
            }

            int sum = dict.Select(a => a.Key).Sum();

            Console.WriteLine($"sum of all numbers is: {sum}");
            Console.ReadLine();
        }
    }
}
