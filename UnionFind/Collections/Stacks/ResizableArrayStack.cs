namespace UnionFind.Collections.Stacks
{
    public class ResizableArrayStack : IStack
    {
        private int _nextFreeIndex = 0;
        private string[] _elements;

        public ResizableArrayStack()
        {
            _elements = new string[1];
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

            if (_nextFreeIndex > 0 && _nextFreeIndex == _elements.Length / 4)
            {
                ResizeArray(_elements.Length / 2);
            }

            return elementToReturn;
        }

        public void Push(string element)
        {
            if (_nextFreeIndex == _elements.Length)
            {
                ResizeArray(_elements.Length * 2);
            }

            _elements[_nextFreeIndex++] = element;
        }

        private void ResizeArray(int capacity)
        {
            var newArray = new string[capacity];

            for (int i = 0; i < _nextFreeIndex; i++)
            {
                newArray[i] = _elements[i];
            }

            _elements = newArray;
        }
    }
}
