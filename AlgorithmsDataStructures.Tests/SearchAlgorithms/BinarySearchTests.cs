using AlgorithmsDataStructures.SearchAlgorithms;
using Xunit;

namespace AlgorithmsDataStructures.Tests.SearchAlgorithms
{
    public class BinarySearchTests
    {
        [Fact]
        public void BinarySearchWorks_Simple()
        {
            int[] elements = { 5, 8, 12 }; // { 6, 13, 14, 25, 33, 43, 51, 53, 64, 72, 84, 93, 95, 96, 97 };

            int result = BinarySearch.Find(elements, 12);

            Assert.Equal(result, 2);

            result = BinarySearch.Find(elements, 5);

            Assert.Equal(result, 0);

            result = BinarySearch.Find(elements, 8);

            Assert.Equal(result, 1);
        }

        [Fact]
        public void BinarySearchWorks_Hard()
        {
            int[] elements = { 6, 13, 14, 25, 33, 43, 51, 53, 64, 72, 84, 93, 95, 96, 97 };

            int result = BinarySearch.Find(elements, 97);

            Assert.Equal(result, 14);
        }
    }
}
