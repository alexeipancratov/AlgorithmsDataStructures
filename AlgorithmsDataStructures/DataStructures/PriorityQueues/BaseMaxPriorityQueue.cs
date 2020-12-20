using System;

namespace AlgorithmsDataStructures.DataStructures.PriorityQueues
{
    public abstract class BaseMaxPriorityQueue<T>
        where T : IComparable<T>
    {
        protected static bool IsLess(T a, T b)
        {
            return a.CompareTo(b) < 0;
        }

        protected static void Exchange(T[] elements, int firstIndex, int secondIndex)
        {
            T temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }
    }
}
