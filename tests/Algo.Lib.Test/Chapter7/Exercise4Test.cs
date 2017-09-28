namespace Algo.Lib.Test.Chapter7
{
    using Lib.Chapter7;
    using Xunit;

    public class Exercise4Test
    {
        [Fact]
        public static void Minus()
        {
            int result = Exercise4.Minus(8, 5);

            Assert.Equal(result, 3);
        }

        [Fact]
        public static void Multiply()
        {
            int result = Exercise4.Multiply(8, 5);

            Assert.Equal(result, 40);
        }

        [Fact]
        public static void Divide()
        {
            int result = Exercise4.Divide(40, 8);

            Assert.Equal(result, 5);
        }
    }
}
