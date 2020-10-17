namespace UnionFind.Collections.Stacks
{
    public class LinkedStack : IStack
    {
        private Node _currentLast = null;

        public void Push(string element)
        {
            Node oldLast = _currentLast;

            var newNode = new Node
            {
                Value = element,
                NextNode = oldLast
            };

            _currentLast = newNode;
        }

        public string Pop()
        {
            string value = _currentLast.Value;
            _currentLast = _currentLast.NextNode;

            return value;
        }

        public bool IsEmpty() => _currentLast == null;
    }
}
