using System;
using System.Diagnostics.CodeAnalysis;

namespace AlgorithmsDataStructures.ConsoleTests.PriorityQueues
{
    internal class Transaction : IComparable<Transaction>
    {
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public int CompareTo([AllowNull] Transaction other)
        {
            return this.Amount.CompareTo(other.Amount);
        }
    }
}
