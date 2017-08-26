using Algo.Lib.Chapter3;
using Xunit;

namespace Algo.Lib.Test.Chapter3
{
    public class Exercise2Test
    {
        [Fact]
        public void Get_min_value_from_stack()
        {
            var stack = new StackMin();
            stack.Push(3);
            stack.Push(9);
            stack.Push(1);

            var min1 = stack.Min();
            stack.Pop();
            var min2 = stack.Min();

            Assert.Equal(min1, 1);
            Assert.Equal(min2, 3);
        }
    }
}
