using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicPermutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Permutations();
            var elements = GetElements();
            var result = p.CreatePermutationsWithoutRepetition(elements.ToList());
            List<string> values = new List<string>();
            foreach (var r in result)
            {
                values.Add(r.ToStringRepresenation());
            }
            values.Sort();
            Console.WriteLine(values[999999]);

            Console.ReadLine();
        }

        private static Element[] GetElements()
        {
            return new Element[]{ 
                new Element(){ Value = 0, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 1, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 2, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 3, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 4, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 5, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 6, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 7, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 8, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 9, Position = LexicographicPermutations.Enums.Positions.Left},
            };
        }
    }
}
