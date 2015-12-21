using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglePath
{
    public class Reader
    {
        private string filePath;
        public Reader(string file)
        {
            filePath = file;
        }

        public int[][] ReadTriangle(int rows)
        {
            int[][] triangle = new int[rows][];
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            { 
                int[] row = new int[counter + 1];
                string[] splitted = line.Split(' ');
                for (int i = 0; i < splitted.Length; i++)
			    {
			        row[i] = Int32.Parse(splitted[i]);
			    }
                triangle[counter] = row;
                counter++;
            }
            return triangle;
        }

        public void Print(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var array = arr[i];
                Console.WriteLine(string.Join(",", array));
            }
        }
    }
}
