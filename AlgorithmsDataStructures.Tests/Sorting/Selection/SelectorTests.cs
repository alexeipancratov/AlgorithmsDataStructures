using AlgorithmsDataStructures.Sorting.Selection;
using Xunit;

namespace AlgorithmsDataStructures.Tests.Sorting.Selection
{
    public class SelectorTests
    {
        [Fact]
        public void Selector_ReturnsKElement()
        {
            var elements = new int[] { 2, 4, 8, 10 };
            int k = 2;

            int result = Selector<int>.Select(elements, k);

            Assert.Equal(8, result);
        }
    }
}
