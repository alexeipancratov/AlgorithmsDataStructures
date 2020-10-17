namespace AlgorithmsDataStructures.Collections.Queues
{
    public interface IQueue
    {
        bool IsEmpty();

        void Enqueue(string element);

        string Dequeue();
    }
}
