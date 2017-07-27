namespace Algo.Lib.Test.Chapter1
{
    using System;
    using Lib.Chapter1;
    using Xunit;

    public class Exercise2Test
    {
        [Fact]
        public static void Try_to_reverse_string()
        {
            string str1 = "abcd";

            string str2 = Exercise2.Reverse(str1);

            Assert.Equal(str2, "dcba");

        }

        [Fact]
        public static void Try_to_reverse_chars_array()
        {
            char[] str = new[] { 'a', 'b', 'c', 'd' };

            Exercise2.Reverse(str);

            Assert.Equal(str[0], 'd');
            Assert.Equal(str[1], 'c');
            Assert.Equal(str[2], 'b');
            Assert.Equal(str[3], 'a');
        }
    }
}
