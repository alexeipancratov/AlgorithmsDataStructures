using System;

namespace UnionFind.SearchAlgorithms
{
    public static class BinarySearch
    {
        public static int Find(int[] elements, int key)
        {
            if (elements.Length == 0)
            {
                Console.WriteLine("Array is empty");
                return -1;
            }

            if (elements.Length == 1)
            {
                Console.WriteLine(elements[0]);
                return elements[0];
            }

            int startIndex = 0;
            int endIndex = elements.Length - 1;
            int indexesSum = startIndex + endIndex;
            int currentIndex = (int)Math.Ceiling(indexesSum / 2m);

            while (true)
            {
                if (elements[currentIndex] == key)
                {
                    return currentIndex;
                }

                if (elements[currentIndex] < key)
                {
                    startIndex = currentIndex + 1;
                    endIndex = elements.Length - 1;
                    indexesSum = startIndex + endIndex;
                    currentIndex = (int)Math.Ceiling(indexesSum / 2m);
                }
                else
                {
                    startIndex = 0;
                    endIndex = currentIndex - 1;
                    indexesSum = startIndex + endIndex;
                    currentIndex = (int)Math.Ceiling(indexesSum / 2m);
                }
            }
        }
    }
}
