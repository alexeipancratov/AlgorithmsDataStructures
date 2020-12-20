using AlgorithmsDataStructures.ConsoleTests.PriorityQueues;
using AlgorithmsDataStructures.DataStructures.PriorityQueues;
using System;

namespace AlgorithmsDataStructures.ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxBinaryHeapPriorityQueueDemo();
        }

        // We want to store M minimum elements from a stream.
        // Here we're using one of the primitive priority queues.
        private static void MaxUnorderedPriorityQueueDemo()
        {
            var transactions = new Transaction[]
            {
                new Transaction { Name = "John", Amount = 13.44m },
                new Transaction { Name = "Alex", Amount = 85.65m },
                new Transaction { Name = "Peter", Amount = 11.27m },
                new Transaction { Name = "Jennifer", Amount = 65.44m },
                new Transaction { Name = "Jennifer", Amount = 10.17m },
            };

            // We want to store M minimum elements from the stream.
            int m = 3;
            IMaxPriorityQueue<Transaction> queue = new UnorderedMaxPriorityQueue<Transaction>(10);

            for (int i = 0; i < transactions.Length; i++)
            {
                queue.Insert(transactions[i]);

                if (queue.Size > m)
                {
                    queue.DeleteMax();
                }
            }

            Console.WriteLine(queue.Size);
            Console.ReadLine();
        }

        private static void MaxBinaryHeapPriorityQueueDemo()
        {
            var transactions = new Transaction[]
            {
                new Transaction { Name = "John", Amount = 13.44m },
                new Transaction { Name = "Alex", Amount = 85.65m },
                new Transaction { Name = "Peter", Amount = 11.27m },
                new Transaction { Name = "Jennifer", Amount = 65.44m },
                new Transaction { Name = "Jennifer", Amount = 101.17m },
            };

            // We want to store M minimum elements from the stream.
            int m = 3;
            IMaxPriorityQueue<Transaction> queue = new BinaryHeapMaxPriorityQueue<Transaction>(10);

            for (int i = 0; i < transactions.Length; i++)
            {
                queue.Insert(transactions[i]);

                if (queue.Size > m)
                {
                    queue.DeleteMax();
                }
            }

            Console.WriteLine(queue.Size);
            Console.ReadLine();
        }
    }
}
