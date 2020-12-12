using System;

namespace AlgorithmsDataStructures.Sorting
{
    /// <summary>
    /// Basically the Quicksort, but just optimized for duplicate elements.
    /// Quicksort could go up to N^2 with duplicates.
    /// NOTE: It can be proved that the number of compares made by this alg. is proportional to the best
    /// you could possibly do, whatever the distribution of equal keys is - entropy-optimal.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ThreeWayQuickSort<T> : BaseSort<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            Sort(elements, 0, elements.Length - 1);
        }

        private void Sort(T[] elements, int low, int high)
        {
            if (high <= low) return;

            int i = low, lessThanPointer = low;
            int greaterThanPointer = high;

            T partitionElement = elements[low];

            while (i <= greaterThanPointer)
            {
                int comparisonResult = elements[i].CompareTo(partitionElement);

                if (comparisonResult < 0)
                    Exchange(elements, lessThanPointer++, i++);
                else if (comparisonResult > 0)
                    Exchange(elements, greaterThanPointer--, i);
                else
                    i++;
            }

            Sort(elements, low, lessThanPointer - 1);
            Sort(elements, greaterThanPointer + 1, high);
        }
    }
}
