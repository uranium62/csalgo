﻿namespace Algo.Lib.Chapter5
{
    public class Exercise5
    {
        public static int BitSwapRequired(int a, int b)
        {
            int count = 0;
            for (int c = a^b; c != 0; c = c >> 1)
            {
                count += c & 1;
            }
            return count;
        }
    }
}
