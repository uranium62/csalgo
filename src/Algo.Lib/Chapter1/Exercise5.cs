namespace Algo.Lib.Chapter1
{
    using System.Text;

    public class Exercise5
    {
        public static string Compress(string str)
        {
            var buf = new StringBuilder(str.Length);
            var last = str[0];
            var count = 1;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == last)
                {
                    count++;
                }
                else
                {
                    buf.Append(last).Append(count);
                    last = str[i];
                    count = 1;
                }
            }
            buf.Append(last).Append(count);

            if (str.Length < buf.Length)
            {
                return str;
            }
            return buf.ToString();
        }
    }
}
