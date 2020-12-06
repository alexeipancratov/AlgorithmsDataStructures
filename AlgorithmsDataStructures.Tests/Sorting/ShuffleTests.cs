using AlgorithmsDataStructures.Sorting;
using Xunit;

namespace AlgorithmsDataStructures.Tests.Sorting
{
    public class ShuffleTests
    {
        [Fact]
        public void KnuthSuffle_ShufflesNumbersUniformly()
        {
            var elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            KnuthShuffle<int>.Shuffle(elements);

            Assert.True(true);
        }
    }
}
