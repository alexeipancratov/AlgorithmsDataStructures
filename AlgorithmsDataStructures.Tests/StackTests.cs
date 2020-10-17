using UnionFind.Collections.Stacks;
using Xunit;

namespace AlgorithmsDataStructures.Tests
{
    public class StackTests
    {
        [Fact]
        public void FixedArrayStack_Works()
        {
            IStack stack = new FixedArrayStack(10);

            stack.Push("To");
            stack.Push("or");
            stack.Push("not");

            Assert.Equal(stack.Pop(), "not");

            stack.Push("be");

            Assert.Equal(stack.Pop(), "be");

            Assert.False(stack.IsEmpty());

            stack.Pop();
            stack.Pop();

            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void ResizableArrayStack_Works()
        {
            IStack stack = new FixedArrayStack(10);

            stack.Push("To");
            stack.Push("or");
            stack.Push("not");

            Assert.Equal(stack.Pop(), "not");

            stack.Push("be");

            Assert.Equal(stack.Pop(), "be");

            Assert.False(stack.IsEmpty());

            stack.Pop();
            stack.Pop();

            Assert.True(stack.IsEmpty());
        }
    }
}
