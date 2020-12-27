using System;

namespace AlgorithmsDataStructures.Sorting
{
    /// <summary>
    /// You can build a heap from N elements in linear time.
    /// And then in NlogN you can sort that heap.
    /// In comparison to MergeSort and QuickSort, Heap Sort is both in-place AND guarantees NlogN time.
    /// 
    /// But in practice isn't used that much since:
    /// - makes poor use of cache memory;
    /// - isn't stable (as opposed to MergeSort).
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class HeapSort<T>
        where T : IComparable<T>
    {
        public static void Sort(T[] elements)
        {
            int length = elements.Length;

            // Build heap using bottom-up method.
            // Start in the middle since the right-hand side of the array is just heaps of size 1.
            for (int k = length / 2; k >= 1; k--)
            {
                Sink(elements, k, length);
            }

            // Sort itself.
            while (length > 1)
            {
                Exchange(elements, 1, length);
                Sink(elements, 1, --length);
            }
        }

        private static void Sink(T[] elements, int index, int numberOfElements)
        {
            while (index * 2 <= numberOfElements)
            {
                int largestChild = index * 2;
                if (largestChild < numberOfElements && IsLess(elements, largestChild, largestChild + 1))
                    largestChild++; // right element

                if (IsLess(elements, largestChild, index))
                    break;

                Exchange(elements, largestChild, index);

                index = largestChild;
            }
        }

        private static bool IsLess(T[] elements, int firstIndex, int secondIndex)
        {
            return elements[firstIndex - 1].CompareTo(elements[secondIndex - 1]) < 0;
        }

        private static void Exchange(T[] elements, int firstIndex, int secondIndex)
        {
            T temp = elements[firstIndex - 1];
            elements[firstIndex - 1] = elements[secondIndex - 1];
            elements[secondIndex - 1] = temp;
        }
    }
}
