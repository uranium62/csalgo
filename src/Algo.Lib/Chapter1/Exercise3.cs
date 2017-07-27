namespace Algo.Lib.Chapter1
{
    public class Exercise3
    {
        public static bool IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int[] symbols = new int[0xFFFF];

            for (int i = 0; i < str1.Length; i++)
            {
                symbols[str1[i]]++;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                if (--symbols[str2[i]] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
