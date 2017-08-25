namespace Algo.Lib.Test.Chapter3
{
    using Lib.Chapter3;
    using Xunit;

    public class Exercise1Test
    {
        [Fact]
        public void Try_to_add_into_stack()
        {
            var stack = new StackArray(5);

            stack.Push(0, 1);
            stack.Push(0, 2);
            stack.Push(0, 3);

            stack.Push(1, 11);
            stack.Push(1, 12);
            stack.Push(1, 13);

            stack.Push(2, 21);
            stack.Push(2, 22);
            stack.Push(2, 23);


            var value0 = stack.Pop(0);
            var value1 = stack.Pop(1);
            var value2 = stack.Pop(2);
            var value3 = stack.Pop(2);
            var value4 = stack.Pop(2);
            var value5 = stack.Pop(1);


            Assert.Equal(value0, 3);
            Assert.Equal(value1, 13);
            Assert.Equal(value2, 23);
            Assert.Equal(value3, 22);
            Assert.Equal(value4, 21);
            Assert.Equal(value5, 12);
        }
    }
}
