using System;

namespace UnionFind.Sorting
{
    public abstract class BaseSort<T>
        where T: IComparable<T>
    {
        public abstract void Sort(T[] elements);

        protected static bool IsLess(T a, T b)
        {
            return a.CompareTo(b) == -1;
        }

        protected static void Exchange(T[] elements, int firstIndex, int secondIndex)
        {
            T temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }
    }
}
