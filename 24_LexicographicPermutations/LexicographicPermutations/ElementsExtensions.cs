using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicPermutations
{
    public static class ElementsExtensions
    {
        public static void SwapLeft(this Element[] elements, Element largestMobile, int largestPosition)
        {
            Element elementToSwap = elements[largestPosition - 1];
            elements[largestPosition - 1] = largestMobile;
            elements[largestPosition] = elementToSwap;
        }

        public static void SwapRight(this Element[] elements, Element largestMobile, int largestPosition)
        {
            Element elementToSwap = elements[largestPosition + 1];
            elements[largestPosition + 1] = largestMobile;
            elements[largestPosition] = elementToSwap;
        }

        public static int GetIndex(this Element[] elements, Element element)
        {
            for (int i = 0; i < elements.Length; i++)
			{
                var e = elements[i];
                if (e.Value == element.Value)
                {
                    return i;
                }
			}
            throw new Exception("Element not found");
        }

        public static List<Element> GetBiggerNumbers(this Element[] elements, Element currentLargest)
        {
            var elems = new List<Element>();
            foreach (var e in elements)
            {
                if (e.Value > currentLargest.Value)
                {
                    elems.Add(e);
                }
            }
            return elems;
        }

        public static void UpdateElements(this Element[] elements, List<Element> biggerElements)
        {
            foreach (var element in biggerElements)
            {
                Element el = elements.Single(e => e.Value == element.Value);
                el.Position = element.Position;
            }
        
        }

        public static int[] GetValues(this Element[] elements)
        {
            List<int> values = new List<int>();
            foreach(Element e in elements)
            {
                values.Add(e.Value);
            }
            return values.ToArray();
        }

        public static string ToStringRepresenation(this Element[] elements)
        {
            string val = "";
            foreach (Element e in elements)
            {
                val += e.Value;
            }
            return val;
        }
    }
}
