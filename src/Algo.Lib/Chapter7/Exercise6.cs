namespace Algo.Lib.Chapter7
{
    using System;
    using System.Collections.Generic;

    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class PointLine
    {
        private static double EPSILON = 0.000001;

        public double slope;
        public double intercept;

        private bool isInfinity;

        public PointLine(Point p1, Point p2)
        {
            if (Math.Abs(p1.x - p2.x) > EPSILON)
            {
                slope = (p1.y - p2.y) / (p1.x - p2.x);
                intercept = p1.y - slope * p1.x;
            }
            else
            {
                isInfinity = true;
                intercept = p1.x;
            }
        }

        public bool IsEqual(double a, double b)
        {
            return Math.Abs(a - b) < EPSILON;
        }

        public override bool Equals(object obj)
        {
            PointLine line = (PointLine) obj;

            return
                IsEqual(line.slope, slope) &&
                IsEqual(line.intercept, intercept) &&
                line.isInfinity == isInfinity;
        }

        public override int GetHashCode()
        {
            int hash = 23;
            hash = hash * 31 + slope.GetHashCode();
            hash = hash * 31 + intercept.GetHashCode();
            return hash;
        }
    } 

    public class Exercise6
    {
        public static PointLine FindLine(Point[] points)
        {
            Dictionary<PointLine, int> lineCount = new Dictionary<PointLine, int>();

            int maxCount = 0;
            var maxLine = new PointLine(points[0], points[1]);

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var line  = new PointLine(points[i], points[j]);

                    if (lineCount.ContainsKey(line))
                    {
                        int tmp = lineCount[line] + 1;
                        lineCount[line] = tmp;

                        if (tmp > maxCount)
                        {
                            maxCount = tmp;
                            maxLine = line;
                        }
                    }
                    else
                    {
                        lineCount.Add(line, 0);

                        if (maxCount == 0)
                        {
                            maxLine = line;
                        }
                    }
                }
            }

            return maxLine;
        }
    }
}
