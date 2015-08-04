using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeSum
{

    /***
     * How it works
     *        999
     *        999
     *        999
     *        999
     *        ----
     *          6 (remainder = 3)
     *         9  (remainder = 3)
     *        9   (remainder = 3)
     = remainder number 
     = 3 996
     * *****/

    class Program
    {
        private static int numberOfNumbers = 100;
        private static int numberSize = 50;
        static void Main(string[] args)
        {
            double remainder = 0;
            var arrayOfNumbers = GetNumbers();
            var s = "";
            for (int i = 49; i >= 0; i--)
            {
                var temp = SumColumn(i, arrayOfNumbers, remainder);
                var number = temp%10;
                s = number + s;
                remainder = (temp - number)/10;
                if (remainder < 1)
                {
                    remainder = 0;
                }
            }
            Console.WriteLine(remainder + s);
            Console.ReadLine();
        }

        private static int[][] GetNumbers()
        {
            var numbers = new List<int[]>();
            var index = 0;
            var count = 1;
            var reader = new StreamReader("Numbers.txt");
            var arrayOfNumbers = new int[50];
            while(!reader.EndOfStream)
            {
                var ch = (char)reader.Read();
                if (ch != '\n' && ch != '\r')
                {
                    //Console.Write(ch);
                    arrayOfNumbers[index] = (int) Char.GetNumericValue(ch);
                    index++;
                    if (count%50 == 0)
                    {
                        numbers.Add(arrayOfNumbers);
                        index = 0;
                        arrayOfNumbers = new int[50];
                        //Console.WriteLine("");
                    }
                    count++;
                }
            }
            reader.Close();
            reader.Dispose();
            return numbers.ToArray();
        }

        private static double SumColumn(int index, int[][] numbers, double remainder)
        {
            double sum = remainder;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                sum = sum + numbers[i][index];
            }
            return sum;
        }
    }
}
