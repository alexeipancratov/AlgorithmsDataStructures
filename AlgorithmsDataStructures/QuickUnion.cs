namespace AlgorithmsDataStructures
{
    public class QuickUnion : IUnionFind
    {
        private readonly int[] _parents;

        public QuickUnion(int numberOfElements)
        {
            _parents = new int[numberOfElements];

            for (int i = 0; i < numberOfElements; i++)
            {
                _parents[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            int indexToChange = GetRoot(p);
            int newValue = GetRoot(q);

            _parents[indexToChange] = newValue;
        }

        public bool AreConnected(int p, int q) => GetRoot(p) == GetRoot(q);

        private int GetRoot(int i)
        {
            while (_parents[i] != i)
            {
                i = _parents[i];
            }

            return i;
        }
    }
}
