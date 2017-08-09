namespace Algo.Lib.Test.Chapter1
{
    using Lib.Chapter1;
    using Xunit;

    public class Exercise8Test
    {
        [Fact]
        public void Check_rotated_string()
        {
            var str1 = "waterbottle";
            var str2 = "erbottlewat";

            var res = Exercise8.IsRotation(str1, str2);

            Assert.True(res);
        }

        [Fact]
        public void Check_unrotated_string()
        {
            var str1 = "abcdf";
            var str2 = "abcdg";

            var res = Exercise8.IsRotation(str1, str2);

            Assert.False(res);
        }
    }
}
