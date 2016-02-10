using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexicographicPermutations
{
    public class Permutations
    {
        //Steinhaus Johnson Trotter permutation algorithm
        //https://tropenhitze.wordpress.com/2010/01/25/steinhaus-johnson-trotter-permutation-algorithm-explained-and-implemented-in-java/
        public List<Element[]> CreatePermutationsWithoutRepetition(List<Element> elements)
        {
            var permutations = new List<Element[]>();
            var orderedElements = elements.OrderBy(e => e.Value).ToArray();
            //return null;
            Element originalLargest = GetLargestMobile(orderedElements);
            bool hasMobile = true;
            while (hasMobile)
            {
                permutations.Add(MakeCopy(orderedElements));
                var currentLargest = GetLargestMobile(orderedElements);
                hasMobile = FirstStepSwapAdj(orderedElements);
                if (IsThereNumberBiggerThan(currentLargest, orderedElements))
                {
                    var biggerNumbers = orderedElements.GetBiggerNumbers(currentLargest);
                    foreach (var element in biggerNumbers)
                    {
                        SwapElementDirection(element);
                    }
                }
            }
            return permutations;
        }

        private Element[] MakeCopy(Element[] orderedElements)
        {
            var elemnts = new Element[orderedElements.Length];
            for (int i = 0; i < orderedElements.Length; i++)
            {
                var e = orderedElements[i];
                elemnts[i] = e;
            }
            return elemnts;
        }

        private void SwapElementDirection(Element element)
        {
            if (element.Position == Enums.Positions.Left)
            {
                element.Position = Enums.Positions.Right;
            }
            else
            {
                element.Position = Enums.Positions.Left;
            }
        }

        private bool IsThereNumberBiggerThan(Element currentLargest, Element[] orderedElements)
        {
            foreach (var item in orderedElements)
            {
                if (item.Value > currentLargest.Value)
                {
                    return true;
                }
            }
            return false;
        }

        public bool FirstStepSwapAdj(Element[] elements)
        {
            Element largestMobile = GetLargestMobile(elements);
            if (largestMobile.Value == -1)
            {
                return false;
            }
            Swap(elements, largestMobile);
            return true;
        }

        private void Swap(Element[] elements, Element largestMobile)
        {
            int largestPosition = elements.GetIndex(largestMobile);
            if (largestMobile.Position == Enums.Positions.Left)
            {
                elements.SwapLeft(largestMobile, largestPosition);
            }
            if (largestMobile.Position == Enums.Positions.Right)
            {
                elements.SwapRight(largestMobile, largestPosition);
            }
        }

        public Element GetLargestMobile(Element[] elements)
        {
            Element largest = new Element() {  Value = -1, Position = Enums.Positions.Left };
            for (int i = 0; i < elements.Length; i++)
            {
                var element = elements[i];
                if (element.Position == Enums.Positions.Left)
                {
                    FigureOutLeft(element, i, elements, largest);
                }
                if (element.Position == Enums.Positions.Right)
                {
                    FigureOutRight(element, i, elements, largest);
                }
            }
            return largest;
        }

        public void FigureOutLeft(Element element, int i, Element[] elements, Element largest)
        {
            if (i == 0)
            {
                //not mobile = is first and point to left
            }
            else
            {
                int leftIndex = i - 1;
                if (element.Value > elements[leftIndex].Value && element.Value > largest.Value)
                {
                    largest.Value = element.Value;
                    largest.Position = element.Position;
                }
            }
        }
        public void FigureOutRight(Element element, int i, Element[] elements, Element largest)
        {
            if (i == (elements.Length - 1))
            {
                //not mobile = is last and point to right
            }
            else
            {
                int rightIndex = i + 1;
                if (element.Value > elements[rightIndex].Value && element.Value > largest.Value)
                {
                    largest.Value = element.Value;
                    largest.Position = element.Position;
                }
            }
        }
    }
}
