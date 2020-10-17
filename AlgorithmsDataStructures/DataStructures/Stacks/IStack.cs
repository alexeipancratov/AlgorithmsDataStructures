namespace AlgorithmsDataStructures.DataStructures.Stacks
{
    public interface IStack
    {
        void Push(string element);

        string Pop();

        bool IsEmpty();
    }
}
