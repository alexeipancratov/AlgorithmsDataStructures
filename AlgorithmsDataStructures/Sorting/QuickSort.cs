using System;

namespace AlgorithmsDataStructures.Sorting
{
    /// <summary>
    /// COmparing to MergeSort doesn't need an additional array.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class QuickSort<T> : BaseSort<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            new KnuthShuffle<T>().Sort(elements); // shuffle the elements for better performance.
            Sort(elements, 0, elements.Length - 1);
        }

        private void Sort(T[] elements, int low, int high)
        {
            if (high <= low) return;
            int j = Partition(elements, low, high);
            Sort(elements, low, j - 1);
            Sort(elements, j + 1, high);
        }

        /// <summary>
        /// Partitions the array into two parts, where the first element of the original array
        /// is the partition element and all the items on the left are no larger
        /// and all the items on the right are not smaller than the partition element.
        /// </summary>
        /// <param name="elements"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns>Returns index of an element known to be in place.</returns>
        private int Partition(T[] elements, int low, int high)
        {
            int i = low, j = high + 1;

            while (true)
            {
                while (true)
                    if (!IsLess(elements[++i], elements[low])) break;

                while (true)
                    if (!IsLess(elements[low], elements[--j])) break;

                if (i >= j) break;

                Exchange(elements, i, j);
            }

            Exchange(elements, low, j);

            return j;
        }
    }
}
