using System;

namespace AlgorithmsDataStructures.Sorting
{
    /// <summary>
    /// Much more efficient than the Insertion sort.
    /// Is based on the fact that a g-sorted array remains g-sorted after h-sorting, i.e. the elements from g sorting will remain on the same places.
    /// E.g. 7-sorted array remains 7-sorted after 3-sorting.
    /// Can be proved mathematically.
    /// So the algorithm is based on this.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ShellSort<T> : BaseSort<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            int h = 1;

            // Increment sequence can be calculated by 3x + 1 (Knuth).
            // which is efficient and is easy to compute. But it's not the best (which remains to be determined).
            // 1, 4, 13, 40, 121, 364...
            while (h < elements.Length / 3)
            {
                h = 3 * h + 1;
            }

            // For h = 1 it's just insertion sort.
            while (h >= 1)
            {
                for (int i = h; i < elements.Length; i++)
                {
                    for (int j = i; j >= h && IsLess(elements[j], elements[j - h]); j -= h)
                    {
                        Exchange(elements, j, j - h);
                    }
                }

                h /= 3;
            }
        }
    }
}
