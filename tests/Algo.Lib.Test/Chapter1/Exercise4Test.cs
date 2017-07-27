namespace Algo.Lib.Test.Chapter1
{
    using Lib.Chapter1;
    using Xunit;

    public class Exercise4Test
    {
        [Fact]
        public void Replace_a_string_without_spaces()
        {
            var str = "Helloworld".ToCharArray();

            var des = Exercise4.ReplaceSpace(str);

            Assert.Equal(new string(des), "Helloworld");
        }

        [Fact]
        public void Replace_a_string_with_spaces()
        {
            var str = " Hello world ".ToCharArray();

            var des = Exercise4.ReplaceSpace(str);

            Assert.Equal(new string(des), "%20Hello%20world%20");
        }
    }
}
