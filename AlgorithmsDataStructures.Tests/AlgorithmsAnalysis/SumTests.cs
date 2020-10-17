using AlgorithmsDataStructures.AlgorithmsAnalysis;
using Xunit;

namespace AlgorithmsDataStructures.Tests.AlgorithmsAnalysis
{
    public class SumTests
    {
        [Fact]
        public void OneSum_ReturnsExpectedResult()
        {
            int result = Sum.OneSum(new int[] { 5, 0, 4, 5, 0, 99 });

            Assert.True(result == 2);
        }

        [Fact]
        public void TwoSum_ReturnsExpectedResult()
        {
            int result = Sum.OneSum(new int[] { -5, 0, -4, 5, 0, 4 });

            Assert.True(result == 2);
        }

        [Fact]
        public void ThreeSum_ReturnsExpectedResult()
        {
            int result = Sum.OneSum(new int[] { -5, 0, -4, 5, 0, 4 });

            Assert.True(result == 2);
        }
    }
}
