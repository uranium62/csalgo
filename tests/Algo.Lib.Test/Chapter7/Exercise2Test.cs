namespace Algo.Lib.Test.Chapter7
{
    using System;
    using Lib.Chapter7;
    using Xunit;

    public class Exercise2Test
    {
        private const double EPSILON = 0.00001d;

        [Fact]
        public void Probability_of_collision_triangle()
        {
            var p = Exercise2.ProbabilityOfCollision();

            Assert.True(Math.Abs(p - 3/4d) < EPSILON);
        }

        [Fact]
        public void Probability_of_collision()
        {
            var p = Exercise2.ProbabilityOfCollision(3);

            Assert.True(Math.Abs(p - 3/4d) < EPSILON);
        }
    }
}
