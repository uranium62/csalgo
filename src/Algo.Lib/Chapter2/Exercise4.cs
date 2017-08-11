namespace Algo.Lib.Chapter2
{
    using System.Collections.Generic;

    public class Exercise4
    {
        public static LinkedList<int> Partition(LinkedList<int> lst, int x)
        {
            LinkedList<int> before = new LinkedList<int>();
            LinkedList<int> after  = new LinkedList<int>();

            foreach (var t in lst)
            {
                if (t < x)
                    before.AddFirst(t);
                else if (t == x)
                    before.AddLast(t);
                else if (t > x)
                    after.AddFirst(t);
            }
            foreach (var t in after)
            {
                before.AddLast(t);
            }

            return before;
        }
    }
}
