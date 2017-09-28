namespace Algo.Lib.Chapter5
{
    public class Exercise6
    {
        public static int SwapOddEventBits(int x)
        {
            return ((x & 0xaaaaaaa) >> 1) | ((x & 0x55555555) << 1);
        }
    }
}
