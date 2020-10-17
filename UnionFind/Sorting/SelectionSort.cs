using System;

namespace UnionFind.Sorting
{
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
