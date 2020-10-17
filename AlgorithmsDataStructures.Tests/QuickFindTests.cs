using UnionFind;
using Xunit;

namespace UnionFindTests
{
    public class QuickFindTests
    {
        private readonly QuickFind _unionFind;
        private readonly int _numberOfElements = 10;

        public QuickFindTests()
        {
            _unionFind = new QuickFind(_numberOfElements);
        }

        [Fact]
        public void GivenUnion_Connected_ReturnsTrue()
        {
            // Arrange
            int p = 0;
            int q = 1;

            _unionFind.Union(p, q);

            // Act & Assert
            Assert.True(_unionFind.AreConnected(p, q));
        }
    }
}
