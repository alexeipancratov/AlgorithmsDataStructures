using System;

namespace AlgorithmsDataStructures.DataStructures.PriorityQueues
{
    public interface IMaxPriorityQueue<T>
        where T : IComparable<T>
    {
        bool IsEmpty();

        void Insert(T key);

        T DeleteMax();

        int Size { get; }
    }
}
