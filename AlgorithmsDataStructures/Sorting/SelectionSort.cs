using System;

namespace AlgorithmsDataStructures.Sorting
{
    /// <summary>
    /// Running time is insensitive to input. Even for sorted array is N^2/2
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SelectionSort<T> : BaseSort<T>
        where T: IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                int minimumElementIndex = i;
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (IsLess(elements[j], elements[minimumElementIndex]))
                    {
                        minimumElementIndex = j;
                    }
                }

                Exchange(elements, i, minimumElementIndex);
            }
        }
    }
}
