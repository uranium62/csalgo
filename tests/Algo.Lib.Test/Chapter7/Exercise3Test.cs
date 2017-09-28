namespace Algo.Lib.Test.Chapter7
{
    using Lib.Chapter7;
    using Xunit;

    public class Exercise3Test
    {
        [Fact]
        public void Check_interseption_of_lines()
        {
            Line l1 = new Line(0.4, 0.8);
            Line l2 = new Line(0.4, 0.9);

            bool isIntersect = Exercise3.Intersect(l1, l2);

            Assert.False(isIntersect);
        }
    }
}
