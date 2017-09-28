namespace Algo.Lib.Chapter7
{
    public class Exercise2
    {
        public static double ProbabilityOfCollision()
        {
            double clockwise = (1/2d) * (1/2d) * (1/2d);
            double counterclockwise = (1/2d) * (1/2d) * (1/2d);

            return 1 - (clockwise + counterclockwise);
        }

        public static double ProbabilityOfCollision(int n)
        {
            double acum = 1;
            for (int i = 0; i < n-1; i++)
            {
                acum *= (1 / 2d);
            }
            return 1 - acum;
        }
    }
}
