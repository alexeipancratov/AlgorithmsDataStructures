namespace AlgorithmsDataStructures
{
    public interface IUnionFind
    {
        void Union(int p, int q);

        bool AreConnected(int p, int q);
    }
}
