namespace Algo.Lib.Chapter2
{
    using System.Collections.Generic;

    public class Exercise1
    {
        public static LinkedList<int> RemoveDups(LinkedList<int> lst)
        {
            LinkedList<int> res = new LinkedList<int>();
            HashSet<int> checker = new HashSet<int>();

            LinkedListNode<int> cur = lst.First;

            while (cur != null)
            {
                if (!checker.Contains(cur.Value))
                {
                    res.AddLast(cur.Value);
                    checker.Add(cur.Value);
                }
                cur = cur.Next;
            }

            return res;
        }
    }
}
