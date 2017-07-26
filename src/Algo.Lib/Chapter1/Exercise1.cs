namespace Algo.Lib.Chapter1
{
    public class Exercise1
    {
        public static bool IsUniqueChar(string str)
        {
            // In the csharp language strings have UTF-16 encoding by default
            if (str.Length > 0xFFFF)
            {
                return false;
            }

            int[] checker = new int[2048];

            for (int i = 0; i < str.Length; i++)
            {
                int rnk = str[i] / 32;
                int pos = str[i] % 32;

                if ((checker[rnk] & (1 << pos)) > 0)
                {
                    return false;
                }
                checker[rnk] |= (1 << pos);
            }

            return true;
        }
    }
}
