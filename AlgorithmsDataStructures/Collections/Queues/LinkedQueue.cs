using System;

namespace AlgorithmsDataStructures.Collections.Queues
{
    public class LinkedQueue : IQueue
    {
        private Node currentFirst = null;
        private Node currentLast = null;

        public string Dequeue()
        {
            string valueToReturn = currentFirst.Value;
            currentFirst = currentFirst.NextNode;

            return valueToReturn;
        }

        public void Enqueue(string element)
        {
            var newNode = new Node
            {
                NextNode = null,
                Value = element
            };

            if (IsEmpty())
            {
                currentFirst = newNode;
                currentLast = newNode;
            }
            else
            {
                currentLast.NextNode = newNode;
                currentLast = newNode;
            }
        }

        public bool IsEmpty() => currentFirst == null;
    }
}
