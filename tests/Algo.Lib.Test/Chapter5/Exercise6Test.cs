namespace Algo.Lib.Test.Chapter5
{
    using Lib.Chapter5;
    using Xunit;

    public class Exercise6Test
    {
        [Fact]
        public void Swap_odd_event_bits()
        {
            int a = 0b1101_1010;

            int b = Exercise6.SwapOddEventBits(a);

            Assert.Equal(b, 0b1110_0101);
        }
    }
}
