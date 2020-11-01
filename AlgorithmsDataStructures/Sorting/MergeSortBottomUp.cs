using System;

namespace AlgorithmsDataStructures.Sorting
{
    /// <summary>
    /// lgN passes, each pass is about N compares. NlgN in total.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MergeSortBottomUp<T> : BaseSort<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            T[] auxiliary = new T[elements.Length];
            for (int size = 1; size < elements.Length; size += size)
            {
                for (int low = 0; low < elements.Length; low += size + size)
                {
                    int middle = low + size - 1;
                    int high = Math.Min(low + size + size - 1, elements.Length - 1);
                    Merge(elements, auxiliary, low, middle, high);
                }
            }
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
