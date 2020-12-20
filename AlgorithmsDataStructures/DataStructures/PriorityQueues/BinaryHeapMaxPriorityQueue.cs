using System;

namespace AlgorithmsDataStructures.DataStructures.PriorityQueues
{
    public class BinaryHeapMaxPriorityQueue<T> : BaseMaxPriorityQueue<T>, IMaxPriorityQueue<T>
        where T : IComparable<T>
    {
        private readonly T[] _elements;
        private int _numberOfElements = 0;

        public BinaryHeapMaxPriorityQueue(int capacity)
        {
            _elements = new T[capacity + 1];
        }

        public int Size => _numberOfElements;

        public T DeleteMax()
        {
            T max = _elements[1];

            Exchange(_elements, 1, _numberOfElements--);
            _elements[_numberOfElements + 1] = default(T);
            Sink(1);

            return max;
        }

        public void Insert(T key)
        {
            _elements[++_numberOfElements] = key;
            Swim(_numberOfElements);
        }

        public bool IsEmpty() => _numberOfElements == 0;

        private void Swim(int index)
        {
            while (index > 1 && IsLess(_elements[index / 2], _elements[index]))
            {
                Exchange(_elements, index / 2, index);
                index /= 2;
            }
        }

        private void Sink(int index)
        {
            while (index * 2 <= _numberOfElements)
            {
                int largestChild = index * 2;
                if (largestChild < _numberOfElements && IsLess(_elements[largestChild], _elements[largestChild + 1]))
                    largestChild++; // right element

                if (IsLess(_elements[largestChild], _elements[index]))
                    break;

                Exchange(_elements, largestChild, index);

                index = largestChild;
            }
        }
    }
}
