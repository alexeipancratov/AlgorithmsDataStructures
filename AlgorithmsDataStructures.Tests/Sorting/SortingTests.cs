using System;
using AlgorithmsDataStructures.Sorting;
using Xunit;

namespace AlgorithmsDataStructures.Tests.Sorting
{
    public class SortingTests
    {
        private readonly BaseSort<int> baseSortNumbers;
        private readonly BaseSort<DateTime> baseSortDates;

        public SortingTests()
        {
            baseSortNumbers = new ShellSort<int>();
            baseSortDates = new SelectionSort<DateTime>();
        }

        [Fact]
        public void Sort_SortsIntsArray()
        {
            var elements = new int[] { 5, 10, 8, 1, 2, 6, 7, 3, 9, 4 };

            baseSortNumbers.Sort(elements);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, elements);
        }

        [Fact]
        public void Sort_SortsDatesArray()
        {
            var elements = new DateTime[] { new DateTime(2020, 02, 01), new DateTime(2019, 06, 01), new DateTime(2004, 07, 01) };

            baseSortDates.Sort(elements);

            Assert.Equal(new DateTime[] { new DateTime(2004, 07, 01), new DateTime(2019, 06, 01), new DateTime(2020, 02, 01) }, elements);
        }
    }
}
