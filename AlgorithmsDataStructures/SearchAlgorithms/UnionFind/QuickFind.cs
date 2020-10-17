namespace AlgorithmsDataStructures.SearchAlgorithms.UnionFind
{
    public class QuickFind : IUnionFind
    {
        private readonly int[] _connections;

        public QuickFind(int numberOfElements)
        {
            _connections = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                _connections[i] = i;
            }
        }

        // Is slow, up to N^2
        public void Union(int p, int q)
        {
            for (int i = 0; i < _connections.Length; i++)
            {
                if (_connections[i] == p)
                {
                    _connections[i] = q;
                }
            }
        }

        public bool AreConnected(int p, int q)
        {
            return _connections[p] == _connections[q];
        }
    }
}
