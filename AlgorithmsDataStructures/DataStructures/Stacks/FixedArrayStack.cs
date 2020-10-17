namespace AlgorithmsDataStructures.DataStructures.Stacks
{
    public class FixedArrayStack : IStack
    {
        private int _nextFreeIndex = 0;
        private readonly string[] _elements;

        public FixedArrayStack(int capacity)
        {
            _elements = new string[capacity];
        }

        public bool IsEmpty() => _nextFreeIndex == 0;

        public string Pop()
        {
            if (IsEmpty())
            {
                return null;
            }

            // .NET GC doesn't know that the object should be removed?
            // return _elements[--_nextFreeIndex];

            string elementToReturn = _elements[--_nextFreeIndex];
            _elements[_nextFreeIndex] = null; // help for GC

            return elementToReturn;
        }

        public void Push(string element)
        {
            _elements[_nextFreeIndex++] = element;
        }
    }
}
