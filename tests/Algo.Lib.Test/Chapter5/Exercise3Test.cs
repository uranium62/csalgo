namespace Algo.Lib.Test.Chapter5
{
    using Lib.Chapter5;
    using Xunit;

    public class Exercise3Test
    {
        [Fact]
        public void Get_next_number()
        {
            int n = 0b11_0110_1111_1100;

            int m = Exercise3.GetNext(n);

            Assert.Equal(m, 0b11_0111_0001_1111);
        }

        [Fact]
        public void Get_prev_number()
        {
            int n = 0b10_0111_1000_0011;

            int m = Exercise3.GetPrev(n);

            Assert.Equal(m, 0b10_0111_0111_0000);
        }
    }
}
