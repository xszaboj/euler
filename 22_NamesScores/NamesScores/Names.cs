using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesScores
{
    public class Names
    {
        IDictionary<char, int> dict = new Dictionary<char, int>(){
            {'a',1},{'b',2},{'c',3},{'d',4},{'e',5},{'f',6},
            {'g',7},{'h',8},{'i',9},{'j',10},{'k',11},{'l',12},
            {'m',13},{'n',14},{'o',15},{'p',16},{'q',17},{'r',18},
            {'s',19},{'t',20},{'u',21},{'v',22},{'w',23},{'x',24},{'y',25},{'z',26}
        };

        public int CalculateName(string name)
        {
            var sum = 0;
            name = name.ToLower();
            foreach (char letter in name)
            {
                sum += dict[letter];
            }
            return sum;
        }

        public long CalculateNamesSum()
        {
            string readText = ReadFile();
            string[] array = ParseFile(readText);
            string[] sorted = SortArray(array);
            return ComputeSum(sorted);
        }

        private long ComputeSum(string[] sorted)
        {
            var position = 1;
            long completeSum = 0;
            foreach (string name in sorted)
            {
                var sum = CalculateName(name);
                completeSum += (sum * position);
                position++;
            }
            return completeSum;
        }

        private string ReadFile()
        {
            return File.ReadAllText("names.txt");
        }

        private string[] ParseFile(string text)
        { 
            text = text.Replace("\"",string.Empty);
            string[] array = text.Split(',');
            return array;
        }

        private string[] SortArray(string[] array)
        {
            Array.Sort<string>(array);
            return array;
        }
    }
}
