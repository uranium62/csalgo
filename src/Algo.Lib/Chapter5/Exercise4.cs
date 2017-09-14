namespace Algo.Lib.Chapter5
{
    public class Exercise4
    {
        public static bool IsPowerOfTwo(int n)
        {
            return (n & (n - 1)) == 0;
        }
    }
}
