namespace Algo.Lib.Test.Chapter1
{
    using Lib.Chapter1;
    using Xunit;

    public class Exercise6Test
    {
        [Fact]
        public void Rotate_3x3_matrix()
        {
            int[,] matrix = new int[,]
            {
                { 1, 2, 3 },
                { 3, 4, 5 },
                { 6, 7, 8 }
            };

            Exercise6.Rotate(matrix, 3);

            Assert.Equal(matrix[0,0], 6);
            Assert.Equal(matrix[0,1], 3);
            Assert.Equal(matrix[0,2], 1);
            Assert.Equal(matrix[1,0], 7);
            Assert.Equal(matrix[1,1], 4);
            Assert.Equal(matrix[1,2], 2);
            Assert.Equal(matrix[2,0], 8);
            Assert.Equal(matrix[2,1], 5);
            Assert.Equal(matrix[2,2], 3);
        }
    }
}
