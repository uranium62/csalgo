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
            stack.PushVal(3);
            stack.PushVal(9);
            stack.PushVal(1);

            var min1 = stack.Min();
            stack.PopVal();
            var min2 = stack.Min();

            Assert.Equal(min1, 1);
            Assert.Equal(min2, 3);
        }
    }
}
