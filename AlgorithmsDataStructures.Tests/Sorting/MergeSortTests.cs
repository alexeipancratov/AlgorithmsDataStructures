using AlgorithmsDataStructures.Sorting;
using FluentAssertions;
using Xunit;

namespace AlgorithmsDataStructures.Tests.Sorting
{
    public class MergeSortTests
    {
        [Fact]
        public void Merge_Works()
        {
            var array = new char[] { 'E', 'E', 'G', 'M', 'R', 'A', 'C', 'E', 'R', 'T' };
            var auxiliary = new char[array.Length];

            MergeSortBottomUp<char>.Merge(array, auxiliary, 0, 4, 9);

            array.Should().BeInAscendingOrder();
        }

        [Fact]
        public void MergeSort_Works()
        {
            var array = new char[] { 'M', 'E', 'R', 'G', 'E', 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            new MergeSortBottomUp<char>().Sort(array);

            array.Should().BeInAscendingOrder();
        }

        [Fact]
        public void MergeSortBottomUpSort_Works()
        {
            var array = new char[] { 'M', 'E', 'R', 'G', 'E', 'S' };

            new MergeSortBottomUp<char>().Sort(array);

            array.Should().BeInAscendingOrder();
        }
    }
}