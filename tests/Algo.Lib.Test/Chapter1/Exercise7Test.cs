namespace Algo.Lib.Test.Chapter1
{
    using Lib.Chapter1;
    using Xunit;

    public class Exercise7Test
    {
        [Fact]
        public void Try_to_zero_matrix()
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 4, 0, 5 },
                { 6, 7, 8 }
            };

            Exercise7.Zero(matrix, 3, 3);

            Assert.Equal(matrix[0, 0], 1);
            Assert.Equal(matrix[0, 1], 0);
            Assert.Equal(matrix[0, 2], 3);
            Assert.Equal(matrix[1, 0], 0);
            Assert.Equal(matrix[1, 1], 0);
            Assert.Equal(matrix[1, 2], 0);
            Assert.Equal(matrix[2, 0], 6);
            Assert.Equal(matrix[2, 1], 0);
            Assert.Equal(matrix[2, 2], 8);
        }
    }
}
