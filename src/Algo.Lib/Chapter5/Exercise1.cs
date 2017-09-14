namespace Algo.Lib.Chapter5
{
    public class Exercise1
    {
        public static int ReplaceBits(int n, int m, int i, int j)
        {
            int allones = ~0;
            int left = allones << (j + 1);
            int right = (1 << i) - 1;

            int mask = left | right;

            int n_cleaned = n & mask;
            int m_shifted = m << i;

            return n_cleaned | m_shifted;
        }
    }
}
