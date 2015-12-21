using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglePath
{
    public class PathCalculator
    {
        private int[][] Triangle;

        public PathCalculator(int[][] triangle)
        {
            Triangle = triangle;
        }

        public int GetMaxPath()
        {
            int firstElement = Triangle[0][0];
            int[] sumRow = new int[2] { Triangle[1][0] + firstElement, Triangle[1][1] + firstElement };
            for (int i = 2; i < Triangle.Length; i++) //start with 2
            {
                sumRow = CalculateSum(Triangle[i], sumRow);
            }
            return sumRow.Max();
        }

        public int[] CalculateSum(int[] currentRow, int[] previousRow)
        {
            int[] sumRow = new int[currentRow.Length];
            var length = currentRow.Length;
            for (int i = 0; i < length; i++)
            {
                int sum = 0;
                var element = currentRow[i];
                if (IsFirst(i))
                {
                    sum = element + previousRow[0]; //first element from previous
                }
                else if (IsLast(i, length))
                {
                    sum = element + previousRow[previousRow.Length - 1]; //last element from previous
                }
                else
                {
                    sum = GetMax(element, previousRow[i - 1], previousRow[i]);
                }
                sumRow[i] = sum;
            }
            return sumRow;
        }

        private int GetMax(int element, int p1, int p2)
        {
            var sum1 = element + p1;
            var sum2 = element + p2;
            return sum1 > sum2 ? sum1 : sum2;
        }

        private bool IsLast(int i, int length)
        {
            return i == (length - 1);
        }

        private bool IsFirst(int index)
        {
            return index == 0;
        }
    }
}
