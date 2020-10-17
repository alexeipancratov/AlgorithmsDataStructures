using AlgorithmsDataStructures;
using Xunit;

namespace AlgorithmsDataStructures.Tests
{
    public class QuickUnionTests
    {
        private readonly QuickUnion _quickUnion;
        private readonly int _numberOfElements = 10;

        public QuickUnionTests()
        {
            _quickUnion = new QuickUnion(_numberOfElements);
        }

        [Fact]
        public void GivenUnion_Connected_ReturnsTrue()
        {
            // Arrange
            _quickUnion.Union(4, 3);
            _quickUnion.Union(3, 8);

            // Act & Assert
            Assert.True(_quickUnion.AreConnected(4, 8));
        }
    }
}
