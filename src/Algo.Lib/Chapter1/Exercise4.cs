namespace Algo.Lib.Chapter1
{
    using System;

    public class Exercise4
    {
        public static char[] ReplaceSpace(char[] str)
        {
            int i, j, spaces = 0;

            for (i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') spaces++;
            }

            var des = new char[str.Length + spaces * 2];
            Array.Copy(str, des, str.Length);

            i = str.Length-1;
            j = des.Length-1;

            while (i != j)
            {
                if (str[i] == ' ')
                {
                    des[j--] = '0';
                    des[j--] = '2';
                    des[j--] = '%';
                    i--;
                }
                else
                {
                    des[j--] = str[i--];
                }
            }

            return des;
        }
    }
}
