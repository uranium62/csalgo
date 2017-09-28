namespace Algo.Lib.Chapter7
{
    using System;

    public class Exercise4
    {
        public static int Negate(int a)
        {
            int neg = 0;
            int num = a > 0 ? -1 : 1;
            while (a !=0)
            {
                neg += num;
                a += num;
            }
            return neg;
        }

        public static int Abs(int a)
        {
            return a > 0 ? a : Negate(a);
        }

        public static int Minus(int a, int b)
        {
            return a + Negate(b);
        }

        public static int Multiply(int a, int b)
        {
            if (a < b)
            {
                return Multiply(b, a);
            }

            int sum = 0;
            for (int i = 0; i < Abs(b); i++)
            {
                sum += a;
            }
            if (b < 0)
            {
                sum = Negate(sum);
            }

            return sum;
        }

        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArithmeticException();
            }
            int absA = Abs(a);
            int absB = Abs(b);

            int prod = 0;
            int x = 0;

            while (prod + absB <= absA)
            {
                prod += absB;
                x++;
            }

            if ((a < 0 && b < 0) || (a > 0 && b > 0))
            {
                return x;
            }
            return Negate(x);
        }
    }
}
