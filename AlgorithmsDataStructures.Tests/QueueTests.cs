using UnionFind.Collections.Queues;
using Xunit;

namespace UnionFindTests
{
    public class QueueTests
    {
        [Fact]
        public void LinkedQueue_Works()
        {
            var queue = new LinkedQueue();

            Assert.True(queue.IsEmpty());

            queue.Enqueue("el1");
            queue.Enqueue("el2");
            queue.Enqueue("el3");

            Assert.Equal("el1", queue.Dequeue());
            Assert.Equal("el2", queue.Dequeue());
            Assert.Equal("el3", queue.Dequeue());

            Assert.True(queue.IsEmpty());
        }
    }
}
