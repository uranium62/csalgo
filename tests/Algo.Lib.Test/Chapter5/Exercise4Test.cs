namespace Algo.Lib.Test.Chapter5
{
    using Lib.Chapter5;
    using Xunit;

    public class Exercise4Test
    {
        [Fact]
        public void Check_is_the_number_is_power_of_two()
        {
            int n1 = 0;
            int n2 = 1;
            int n3 = 2;
            int n4 = 4;
            int n5 = 32;
            int n6 = 1024;

            int n7 = 3;
            int n8 = 11;
            int n9 = 12;

            bool res1 = Exercise4.IsPowerOfTwo(n1);
            bool res2 = Exercise4.IsPowerOfTwo(n2);
            bool res3 = Exercise4.IsPowerOfTwo(n3);
            bool res4 = Exercise4.IsPowerOfTwo(n4);
            bool res5 = Exercise4.IsPowerOfTwo(n5);
            bool res6 = Exercise4.IsPowerOfTwo(n6);
            bool res7 = Exercise4.IsPowerOfTwo(n7);
            bool res8 = Exercise4.IsPowerOfTwo(n8);
            bool res9 = Exercise4.IsPowerOfTwo(n9);

            Assert.True(res1);
            Assert.True(res2);
            Assert.True(res3);
            Assert.True(res4);
            Assert.True(res5);
            Assert.True(res6);

            Assert.False(res7);
            Assert.False(res8);
            Assert.False(res9);
        }
    }
}
