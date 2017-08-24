namespace Algo.Lib.Chapter2
{
    using System;
    using System.Collections.Generic;

    public class Exercise5
    {
        public static LinkedList<int> Sum(LinkedList<int> arg1, LinkedList<int> arg2)
        {
            LinkedList<int> buf = new LinkedList<int>();

            int carry = 0;
            int value = 0;

            var node1 = arg1.Last;
            var node2 = arg2.Last;

            while (node1 != null && node2 != null)
            {
                int tmp = node1.Value + node2.Value + carry;

                value = tmp % 10;
                carry = tmp / 10;

                buf.AddFirst(value);

                node1 = node1.Previous;
                node2 = node2.Previous;
            }

            if (node1 != null)
            {
                while(node1 != null)
                {
                    int tmp = node1.Value + carry;

                    value = tmp % 10;
                    carry = tmp / 10;

                    buf.AddFirst(value);

                    node1 = node1.Previous;
                }
            }

            if (node2 != null)
            {
                while (node2 != null)
                {
                    int tmp = node2.Value + carry;

                    value = tmp % 10;
                    carry = tmp / 10;

                    buf.AddFirst(value);

                    node2 = node2.Previous;
                }
            }

            if (carry != 0)
            {
                buf.AddFirst(carry);
            }

            return buf;
        }
    }
}
