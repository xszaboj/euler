using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\temp\\test.txt");
            double count = 0;
            var transalator = new IntToWordConverter();
            for (var i = 1; i <= 1000; i++)
            {
                var text = transalator.GetTextWithoutSpecialCharacters(i);
                file.WriteLine(text);
                count += text.Length;
            }
            Console.WriteLine(count);
            file.Close();
            Console.ReadLine();
        }
    }
}
