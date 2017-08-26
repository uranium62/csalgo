using Algo.Lib.Chapter3;
using System.Collections.Generic;
using Xunit;

namespace Algo.Lib.Test.Chapter3
{
    public class Exercise6Test
    {
        [Fact]
        public void Sort_a_stack()
        {
            var stack = new Stack<int>();
            stack.Push(4);
            stack.Push(1);
            stack.Push(5);
            stack.Push(2);
            stack.Push(3);

            var des = Exercise6.Sort(stack);

            Assert.Equal(des.Pop(), 1);
            Assert.Equal(des.Pop(), 2);
            Assert.Equal(des.Pop(), 3);
            Assert.Equal(des.Pop(), 4);
            Assert.Equal(des.Pop(), 5);
        }
    }
}
