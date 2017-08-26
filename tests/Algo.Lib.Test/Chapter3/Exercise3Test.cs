using Algo.Lib.Chapter3;
using Xunit;

namespace Algo.Lib.Test.Chapter3
{
    public class Exercise3Test
    {
        [Fact]
        public void Add_elements_into_set_of_stack()
        {
            SetOfStacks set = new SetOfStacks(3);
            set.Push(1);
            set.Push(2);
            set.Push(3);
            set.Push(4);
            set.Push(5);
            set.Push(6);
            set.Push(7);

            var count = set.Count;
            var elemt = set.Pop();

            Assert.Equal(count, 3);
            Assert.Equal(elemt, 7);
        }
    }
}
