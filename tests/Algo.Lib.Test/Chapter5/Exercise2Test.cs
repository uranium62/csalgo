namespace Algo.Lib.Test.Chapter5
{
    using Lib.Chapter5;
    using Xunit;

    public class Exercise2Test
    {
        [Fact]
        public void Print_binary_double_number()
        {
            double num = 0.72; 

            string str = Exercise2.PrintBinary(num);

            Assert.Equal(str, ".1011100001010001");
        }
    }
}
