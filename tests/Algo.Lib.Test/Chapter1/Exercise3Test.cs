namespace Algo.Lib.Test.Chapter1
{
    using Lib.Chapter1;
    using Xunit;

    public class Exercise3Test
    {
        [Fact]
        public static void Check_two_permutation_strings()
        {
            string str1 = "abc";
            string str2 = "bac";

            var res = Exercise3.IsPermutation(str1, str2);

            Assert.True(res);
        }

        [Fact]
        public static void Check_two_unpermutation_strings()
        {
            string str1 = "abc";
            string str2 = "abd";

            var res = Exercise3.IsPermutation(str1, str2);

            Assert.False(res);
        }
    }
}
