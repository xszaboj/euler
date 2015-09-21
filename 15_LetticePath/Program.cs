using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetticePath
{
    public class Program
    {
        /**Solution:
        * Number of posibilities for Lattice paths is equal to middle numbers
        *in Pythagorean triangle
        *also good: http://www.robertdickau.com/lattices.html
        **/
        static void Main(string[] args)
        {
            var triangle = CreatePytaghorasTriangle(21);
            Console.WriteLine(triangle[20, 20]);
            Console.ReadLine();
        }

        public static long[,] CreatePytaghorasTriangle(int size)
        {
            long[,] multiArray = new long[size,size];
            //first row are only 1
            for (var i = 0; i < size; i++)
            {
                multiArray[0,i] = 1;
            }
            for (var i = 1; i < size; i++)
            {
                int previousRow = i - 1;
                int currentRow = i;
                multiArray[i, 0] = 1;
                for (var j = 1; j < size; j++)
                {
                    var valueOne = multiArray[previousRow, j];
                    var valueTwo = multiArray[currentRow,j - 1];
                    multiArray[currentRow,j] = valueOne + valueTwo;
                }
            }
            return multiArray;
        }
    }
}
