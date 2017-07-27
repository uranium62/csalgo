namespace Algo.Lib.Chapter1
{
    public class Exercise2
    {
        public static void Reverse(char[] str)
        {
            int start = 0;
            int end = str.Length - 1;

            while (start < end)
            {
                char tmp = str[start];
                str[start++] = str[end];
                str[end--] = tmp;
            }
        }

        public static string Reverse(string str)
        {
            int start = 0;
            int end = str.Length - 1;
            char[] buf = str.ToCharArray();

            while (start < end)
            {
                char tmp = str[start];
                buf[start++] = buf[end];
                buf[end--] = tmp;
            }

            return new string(buf);
        }
    }
}
