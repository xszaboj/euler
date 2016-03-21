using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSpiralDiagonals
{
    public class NumberSpiral
    {
        public int CalculateDiagonal(int sideSize)
        {
            int size = 0;
            int cycle = 1;
            int current = 1;
            List<int> rightDiagonal = new List<int>();
            List<int> leftDiagonal = new List<int>();
            while (size < sideSize)
            {
                size = GetSize(cycle);
                current = AddToDiagonal(current, size, rightDiagonal);
                current = AddToDiagonal(current, size, leftDiagonal);
                current = AddToDiagonal(current, size, rightDiagonal);
                current = AddToDiagonal(current, size, leftDiagonal);
                cycle++;
            }
            return rightDiagonal.Sum() + leftDiagonal.Sum() + 1; // +1 because that is first number in chain that is not generated
        }

        private int AddToDiagonal(int current, int size, List<int> diagonal)
        {
           current = GenerateNumber(size, current);
           //corner
           current++;
           diagonal.Add(current);
           return current;
        }

        public static int GetSize(int cycle)
        {
            return cycle + (cycle - 1);
        }

        public static int GenerateNumber(int size, int current)
        {
            var next = current + size;
            return next;
        }
    }
}
