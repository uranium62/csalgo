using Algo.Lib.Chapter3;
using Xunit;

namespace Algo.Lib.Test.Chapter3
{
    public class Exercise5Test
    {
        [Fact]
        public void Add_an_element_to_stackqueue()
        {
            var queue = new StackQueue();
            queue.Push(1);
            queue.Push(2);
            queue.Push(3);
            queue.Push(4);
            queue.Push(5);

            var value1 = queue.Pop();
            var value2 = queue.Pop();
            var value3 = queue.Pop();

            Assert.Equal(value1, 1);
            Assert.Equal(value2, 2);
            Assert.Equal(value3, 3);
        }
    }
}
