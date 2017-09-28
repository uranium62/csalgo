namespace Algo.Lib.Test.Chapter5
{
    using Lib.Chapter5;
    using Xunit;

    public class Exercise5Test
    {
        [Fact]
        public void Bit_swap_required()
        {
            int a = 0b1100_0101_1111;
            int b = 0b1101_1101_1110;

            int c = Exercise5.BitSwapRequired(a, b);

            Assert.Equal(c, 3);
        }
    }
}
