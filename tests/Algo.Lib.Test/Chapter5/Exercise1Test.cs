namespace Algo.Lib.Test.Chapter5
{
    using Lib.Chapter5;
    using Xunit;

    public class Exercise1Test
    {
        [Fact]
        public void Replace_bits()
        {
            int n = 0b100_0000_0000;
            int m = 0b1_0011;
            int i = 2, j = 6;

            var r = Exercise1.ReplaceBits(n, m, i, j);

            Assert.Equal(r, 0b100_0100_1100);
        }
    }
}
