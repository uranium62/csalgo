namespace Algo.Lib.Test.Chapter7
{
    using Lib.Chapter7;
    using Xunit;

    public class Exercise6Test
    {
        [Fact]
        public void Find_the_best_line()
        {
            Point[] points = new Point[]
            {
                new Point(0, 0),
                new Point(1, 1),
                new Point(2, 2),
                new Point(3, 3),
                new Point(4, 4),
                new Point(5, 5),
                new Point(8, 7),
                new Point(1, 3),
                new Point(4, 3),
            };

            PointLine line = Exercise6.FindLine(points);

            Assert.True(line.Equals(
                new PointLine(
                    new Point(0, 0), 
                    new Point(1, 1))));
        }
    }
}
