using System;

namespace AlgorithmsDataStructures.Sorting
{
    public class InsertionSort<T> : BaseSort<T>
        where T : IComparable<T>
    {
        public override void Sort(T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (IsLess(elements[j], elements[j - 1]))
                    {
                        Exchange(elements, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
