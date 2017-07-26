namespace Algo.Lib.Test.Chapter1
{
    using Lib.Chapter1;
    using Xunit;

    public class Exercise1Test
    {
        [Fact]
        public void Check_an_unique_string()
        {
            var str = "ABCabc";

            var res = Exercise1.IsUniqueChar(str);

            Assert.True(res);
        }

        [Fact]
        public void Check_an_ununique_string()
        {
            var str = "ABCAbc";

            var res = Exercise1.IsUniqueChar(str);

            Assert.False(res);
        }

    }
}
