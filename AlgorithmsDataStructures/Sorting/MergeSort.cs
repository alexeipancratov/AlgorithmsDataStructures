using System;

namespace AlgorithmsDataStructures.Sorting
{
    /// <summary>
    /// NlgN compares and 6NlgN array accesses sort any array of size N.
    /// Much more efficient than Insertion/Selection sort.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MergeSort<T> : BaseSort<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            T[] auxiliary = new T[elements.Length];
            Sort(elements, auxiliary, 0, elements.Length - 1);
        }

        private void Sort(T[] array, T[] auxiliary, int low, int high)
        {
            if (high <= low)
            {
                return;
            }
            
            int middle = low + (high - low) / 2;
            Sort(array, auxiliary, low, middle);
            Sort(array, auxiliary, middle + 1, high);
            Merge(array, auxiliary, low, middle, high);
        }

        public static void Merge(T[] array, T[] auxiliary, int low, int middle, int high)
        {
            for (int k = 0; k < array.Length; k++)
            {
                auxiliary[k] = array[k];
            }

            int i = low;
            int j = middle + 1;

            for (int k = low; k <= high; k++)
            {
                if (i > middle)
                {
                    array[k] = auxiliary[j++];
                }
                else if (j > high)
                {
                    array[k] = auxiliary[i++];
                }
                else if (IsLess(auxiliary[j], auxiliary[i]))
                {
                    array[k] = auxiliary[j++];
                }
                else
                {
                    array[k] = auxiliary[i++];
                }
            }
        }
    }
}