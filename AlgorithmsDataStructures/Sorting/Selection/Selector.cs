using System;

namespace AlgorithmsDataStructures.Sorting.Selection
{
    /// <summary>
    /// Finds the k-th largest element (0-based).
    /// E.g. [10, 8, 2, 4]. k=2 => 8
    /// Can be used to find min, max, median.
    /// Is based on the QuickSort partition.
    /// The question is can it be linear? Or this task is as complex as sorting. It's as sorting,
    /// but there's linear algorithm, but which it not used in practice - Floyd–Rivest algorithm.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Selector<T>
        where T : IComparable<T>
    {
        public static T Select(T[] elements, int k)
        {
            KnuthShuffle<T>.Shuffle(elements);
            int low = 0, high = elements.Length - 1;
            while (high > low)
            {
                // The element known to be in place.
                int partitionElement = Partition(elements, low, high);

                if (k < partitionElement)
                    high = partitionElement - 1;
                else if (k > partitionElement)
                    low = partitionElement + 1;
                else
                    return elements[k];
            }

            return elements[k];
        }

        private static int Partition(T[] elements, int low, int high)
        {
            int i = low, j = high + 1;

            while (true)
            {
                while (IsLess(elements[++i], elements[low]))
                    if (i == high) break;

                while (IsLess(elements[low], elements[--j]))
                    if (j == low) break;

                if (i >= j) break;

                Exchange(elements, i, j);
            }

            Exchange(elements, low, j);

            return j;
        }

        protected static bool IsLess(T a, T b)
        {
            return a.CompareTo(b) < 0;
        }

        protected static void Exchange(T[] elements, int firstIndex, int secondIndex)
        {
            T temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }
    }
}
