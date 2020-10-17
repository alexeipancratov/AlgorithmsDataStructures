using AlgorithmsDataStructures.SearchAlgorithms.UnionFind;
using Xunit;

namespace AlgorithmsDataStructures.Tests
{
    public class QuickUnionWeightedTests
    {
        private readonly QuickUnionWeighted _quickUnion;
        private readonly int _numberOfElements = 10;

        public QuickUnionWeightedTests()
        {
            _quickUnion = new QuickUnionWeighted(_numberOfElements);
        }

        [Fact]
        public void GivenUnion_Connected_ReturnsTrue()
        {
            // Arrange
            _quickUnion.Union(3, 4);
            _quickUnion.Union(3, 8);
            _quickUnion.Union(6, 5);
            _quickUnion.Union(9, 4);
            _quickUnion.Union(2, 1);
            _quickUnion.Union(5, 0);
            _quickUnion.Union(7, 2);
            _quickUnion.Union(6, 1);
            _quickUnion.Union(7, 3);

            // Act & Assert
            Assert.True(_quickUnion.AreConnected(4, 8));
        }
    }
}
