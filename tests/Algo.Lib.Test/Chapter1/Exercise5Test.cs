namespace Algo.Lib.Test.Chapter1
{
    using Lib.Chapter1;
    using Xunit;

    public class Exercise5Test
    {
        [Fact]
        public void Compress_a_simple_string()
        {
            string str = "aaavrrrrrtf";

            string res = Exercise5.Compress(str);

            Assert.Equal(res, "a3v1r5t1f1");
        }
    }
}
