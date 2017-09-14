namespace Algo.Lib.Chapter5
{
    using System;
    using System.Text;

    public class Exercise2
    {
        private const double Epselon = 0.0001;

        public static string PrintBinary(double num)
        {
            if (num >= 1 || num <= 0)
            {
                throw new ArgumentException("The number can't be less than 0 or greater then 1");
            }

            StringBuilder buf = new StringBuilder();
            buf.Append(".");

            while (num > 0)
            {
                if (buf.Length > 16)
                {
                    return buf.ToString();
                }

                double r = num * 2;
                if (r >= 1)
                {
                    buf.Append(1);
                    num = r - 1;
                }
                else
                {
                    buf.Append(0);
                    num = r;
                }
            }
            return buf.ToString();
        }
    }
}
