using System;

namespace AlgorithmsDataStructures.DataStructures.PriorityQueues
{
    /// <summary>
    /// Two approaches to primitive PriorityQueues:
    /// Unordered - so we have to find max on each DeleteMax;
    /// Ordered - we maintain the order on each insert.
    /// 
    /// Takes M * N (N - number of analyzed elements). We want this to take logN.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UnorderedMaxPriorityQueue<T> : BaseMaxPriorityQueue<T>, IMaxPriorityQueue<T>
        where T : IComparable<T>
    {
        private readonly T[] _elements;
        private int _numberOfElements = 0;

        public UnorderedMaxPriorityQueue(int capacity)
        {
            _elements = new T[capacity];
        }

        public int Size => _numberOfElements;

        public T DeleteMax()
        {
            int maxIndex = 0;
            for (int i = 1; i < _numberOfElements; i++)
            {
                if (IsLess(_elements[maxIndex], _elements[i]))
                {
                    maxIndex = i;
                }
            }

            Exchange(_elements, maxIndex, _numberOfElements - 1);

            return _elements[--_numberOfElements]; // null out entry to prevent loitering.
        }

        public void Insert(T key)
        {
            _elements[_numberOfElements++] = key;
        }

        public bool IsEmpty()
        {
            return _numberOfElements == 0;
        }
    }
}
