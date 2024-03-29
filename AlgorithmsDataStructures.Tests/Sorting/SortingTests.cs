﻿using System;
using AlgorithmsDataStructures.Sorting;
using Xunit;

namespace AlgorithmsDataStructures.Tests.Sorting
{
    public class SortingTests
    {
        private readonly BaseSort<DateTime> baseSortDates;

        public SortingTests()
        {
            baseSortDates = new SelectionSort<DateTime>();
        }

        [Fact]
        public void SelectionSort_SortsIntsArray()
        {
            var elements = new int[] { 5, 10, 8, 1, 2, 6, 7, 3, 9, 4 };

            new SelectionSort<int>().Sort(elements);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, elements);
        }

        [Fact]
        public void InsertionSort_SortsIntsArray()
        {
            var elements = new int[] { 5, 10, 8, 1, 2, 6, 7, 3, 9, 4 };

            new InsertionSort<int>().Sort(elements);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, elements);
        }

        [Fact]
        public void ShellSort_SortsIntsArray()
        {
            var elements = new int[] { 5, 10, 8, 1, 2, 6, 7, 3, 9, 4 };

            new ShellSort<int>().Sort(elements);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, elements);
        }

        [Fact]
        public void QuickSort_SortsIntsArray()
        {
            var elements = new int[] { 5, 10, 8, 1, 2, 6, 7, 3, 9, 4 };

            new QuickSort<int>().Sort(elements);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, elements);
        }

        [Fact]
        public void ThreeWayQuickSort_SortsIntsArray()
        {
            var elements = new char[] { 'P', 'A', 'B', 'X', 'W', 'P', 'P', 'V', 'P', 'D', 'P', 'C', 'Y', 'Z' };

            new ThreeWayQuickSort<char>().Sort(elements);

            Assert.Equal(new char[] { 'A', 'B', 'C', 'D', 'P', 'P', 'P', 'P', 'P', 'V', 'W', 'X', 'Y', 'Z' }, elements);
        }

        [Fact]
        public void HeapSort_SortsIntsArray()
        {
            var elements = new char[] { 'S', 'O', 'R', 'T', 'E', 'X', 'A', 'M', 'P', 'L', 'E' };

            HeapSort<char>.Sort(elements);

            Assert.Equal(new char[] { 'A', 'E', 'E', 'L', 'M', 'O', 'P', 'R', 'S', 'T', 'X' }, elements);
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
