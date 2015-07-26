using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestProductInGrid
{
    class Program
    {
        private static int sizeOfGrid = 20;
        private static int adjecentNumbers = 4;
        static void Main(string[] args)
        {

            var grid = CreateGrid();

            int heighest = Count(grid);

            Console.WriteLine(heighest);
          
            Console.ReadLine();
        }

        private static int[] TransformToNumbers(string line)
        {
            var numbers = line.Split(' ');
            var intNumbers = new int[sizeOfGrid];
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);
                intNumbers[i] = number;
            }
            return intNumbers;
        }

        private static int[,] CreateGrid()
        {
            var grid = new int[sizeOfGrid, sizeOfGrid]; 
            int position = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("Grid.txt");
            while ((line = file.ReadLine()) != null)
            {
                var numbers = TransformToNumbers(line);
                for (int i = 0; i < numbers.Length; i++)
                {
                    var number = numbers[i];
                    grid[position, i] = number;
                }
                position++;
            }

            file.Close();
            return grid;
        }

        private static int Count(int[,]  grid)
        {
            var heighest = 0;
            int[,] heighestSquare = null;
            for (var y = 0; y < sizeOfGrid - adjecentNumbers; y++)
            {
                for (var x = 0; x < sizeOfGrid - adjecentNumbers; x++)
                {
                    var square = CreateSquare(x, y, grid);
                    if (y % adjecentNumbers == 0)
                    {
                        var heighestNumberFromRow = ProductInRowsOfSquare(square);
                        if (heighestNumberFromRow > heighest)
                        {
                            heighest = heighestNumberFromRow;
                            heighestSquare = square;
                        }
                    }
                    if (x % adjecentNumbers == 0)
                    {
                        var heighestNumberFromColumn = ProductInColumnOfSquare(square);
                        if (heighestNumberFromColumn > heighest)
                        {
                            heighest = heighestNumberFromColumn;
                            heighestSquare = square;
                        }
                    }
                    var heighestDiagonal = ProductInDiagonalOfSquare(square);
                    if (heighestDiagonal > heighest)
                    {
                        heighest = heighestDiagonal;
                        heighestSquare = square;
                    }
                }
            }
            return heighest;
        }

        private static int[,] CreateSquare(int x, int y, int[,]  grid)
        {
            var square = new int[adjecentNumbers, adjecentNumbers];
            for (int i = 0; i < adjecentNumbers; i++)
            {
                for (int j = 0; j < adjecentNumbers; j++)
                {
                    square[i,j] = grid[y,x];
                    x++;
                }
                x = x - adjecentNumbers;
                y++;
            }
            return square;
        }

        private static int ProductInRowsOfSquare(int[,] square)
        {
            var heighest = 0;
            for (int i = 0; i < adjecentNumbers; i++)
            { 
                var product = square[i,0] * square[i,1] * square[i,2] * square[i,3];
                if (product > heighest)
                {
                    heighest = product;
                }
            }
            return heighest;
        }

        private static int ProductInColumnOfSquare(int[,] square)
        {
            var heighest = 0;
            for (int i = 0; i < adjecentNumbers; i++)
            {
                var product = square[0, i] * square[1, i] * square[2, i] * square[3, i];
                if (product > heighest)
                {
                    heighest = product;
                }
            }
            return heighest;
        }

        private static int ProductInDiagonalOfSquare(int[,] square)
        {
            var heighest = 0;
            for (int i = 0; i < adjecentNumbers; i++)
            {
                //Right digonal
                var product = square[0, 0] * square[1, 1] * square[2, 2] * square[3, 3];
                if (product > heighest)
                {
                    heighest = product;
                }
                //left diagonal
                var product2 = square[3, 0] * square[2, 1] * square[1, 2] * square[0, 3];
                if (product2 > heighest)
                {
                    heighest = product2;
                }
            }
            return heighest;
        }
    }
}
