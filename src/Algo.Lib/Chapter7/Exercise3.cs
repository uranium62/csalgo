using System;

namespace Algo.Lib.Chapter7
{
    public struct Line
    {
        public const double EPSILON = 0.000001d;

        public double slope;
        public double yintercept;

        public Line(double s, double y)
        {
            slope = s;
            yintercept = y;
        }

        public bool Intersect(Line l2)
        {
            return
                Math.Abs(slope - l2.slope) > EPSILON ||
                Math.Abs(yintercept - l2.yintercept) < EPSILON;
        }
    }

    public class Exercise3
    {
        public static bool Intersect(Line l1, Line l2)
        {
            return l1.Intersect(l2);
        }
    }
}
