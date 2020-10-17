using System;

namespace AlgorithmsDataStructures.Sorting
{
    public class ShellSort<T> : BaseSort<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            int h = 1;

            while (h < elements.Length / 3)
            {
                h = 3 * h + 1;
            }

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
